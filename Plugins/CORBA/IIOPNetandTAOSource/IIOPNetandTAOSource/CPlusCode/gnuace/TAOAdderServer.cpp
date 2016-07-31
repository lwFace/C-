// TAOAdderServer.cpp
//
// @file TAOAdderServer.cpp
// @author Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
// @date 23 November 2005
//
// This is a simple NameService using server implimentation using ACE/TAO.
//
// This example serves a SLB.ExampleInterfaces.IAdder object. The IAdder object is defined 
// in ExampleInterfaces.idl and implemented in ExampleInterfaces_i.cpp.
//
// This server is complementary to the following clients:
//	1.	TAOAdderClient - a simple TAO NameService using C++ ACE/TAO client.
//	2.	DotNetNSAdderClient - a TAO NameService using C# IIOP.NET client.
//
// This server is interchangeable with the following servers:
//  1.	DotNetNSAdderServer - a TAO NameService using C# IIOP.NET server.
//
// The first example demonstrates a C++ TAO Server communicating with a C++ TAO Client where the communication
// is mediated through a TAO NamingService. To use this example do the following:
//	1.	Start the TAO Naming_Service:  %TAO_ROOT%\orbsvcs\Naming_Service\Release\Naming_Service.exe %NS%
//		where %NS% = -m 0 -ORBEndpoint iiop://localhost:2809 -ORBDebugLevel 4
//	2.	Start the TAOAdderServer: TAOAdderServer.exe %NSC%
//		where %NSC% = -ORBInitRef NameService=iiop://localhost:2809/NameService
//	3.	Start the TAOAdderClient: TAOAdderClient.exe %NSC%
//
// The second example demonstrates a C++ TAO Server communicating with a C# IIOPNet client where the
// communication is mediated through a TAO NamingService.  To use this example do the following:
//	1.	Start the TAO Naming_Service:  %TAO_ROOT%\orbsvcs\Naming_Service\Release\Naming_Service.exe %NS%
//		where %NS% = -m 0 -ORBEndpoint iiop://localhost:2809 -ORBDebugLevel 4
//	2.	Start the TAOAdderServer: TAOAdderServer.exe %NSC%
//		where %NSC% = -ORBInitRef NameService=iiop://localhost:2809/NameService
//	3.	Start the DotNetNSAdderClient: DotNetNSAdderClient mynshost 2809
//		where mynshost is the named NameService host and 2809 is the NameService port.

#include "ExampleInterfaces_i.h"
#include <orbsvcs/CosNamingC.h>
#include <orbsvcs/Naming/Naming_Client.h>
#include <ace/streams.h>

int main( int argc, char *argv[] )
{
  try 
  {
	// Initialize CORBA Object Request Broker
	CORBA::ORB_var orb = CORBA::ORB_init( argc, argv );

	//Get reference to Root POA
	CORBA::Object_var obj = orb->resolve_initial_references( "RootPOA" );
	PortableServer::POA_var poa = PortableServer::POA::_narrow( obj.in() );

	// Activate POA Manager
	PortableServer::POAManager_var mgr = poa->the_POAManager();
	mgr->activate();

    // Find the Naming Service
	CORBA::Object_var naming_obj = orb->resolve_initial_references("NameService");
	CosNaming::NamingContext_var root = CosNaming::NamingContext::_narrow(naming_obj.in());
	if(CORBA::is_nil(root.in()))
	{
		cerr << "Could not narrow NameService to NamingContext!" << endl;
		throw 0;
	}

	// Bind the Naming Context to a well known name so clients can find it by name.
	// Interested parties can see the "well known" namespace's and interfaces that might 
	// be available on a given NameService using a utility like nslist or nslister.
	// It makes sense to use the IDL-defined Module (namespace) for the first entry...
	CosNaming::Name name;
    name.length(1);
    name[0].id = CORBA::string_dup("ExampleInterfaces");	// Namespace "SLB.ExampleInterfaces"
    try 
	{
      CORBA::Object_var dummy = root->resolve(name);
    }
    catch (CosNaming::NamingContext::NotFound& ) 
	{
	  // If the binding for that name does not already exist on NameService, then create it...
      CosNaming::NamingContext_var dummy = root->bind_new_context(name);
    }
       
    // ... and to use the IDL-defined Interface (interface or class) for the second entry.
    name.length(2);
    name[1].id = CORBA::string_dup( "IAdder" );	// (interface) class "IAdder"

	// Create a Servant (of the implimentation class), and bind the servant object type to the name.
    ExampleInterfaces_IAdder_i adderServant;  
    PortableServer::ObjectId_var oid = poa->activate_object(&adderServant);
	CORBA::Object_var adderServant_obj = poa->id_to_reference(oid.in());
	root->rebind(name,adderServant_obj.in());
    
    cout << "IAdder interface has been registered on the Naming Service" << endl;

    // Accept requests
    orb->run();
    orb->destroy();
  }
  catch( CORBA::Exception& ex ) 
  {
    cerr << "Caught a CORBA exception: " << ex << endl;
    return 1;
  }
  return 0;
}
