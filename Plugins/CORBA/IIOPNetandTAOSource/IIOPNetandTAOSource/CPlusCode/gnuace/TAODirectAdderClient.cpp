// DirectTAOAdderClient.cpp
//
// @file DirectTAOAdderClient.cpp
// @author Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
// @date 23 November 2005
//
// This example demonstrates a direct connection between a C# .NET IIOPNet based server and a C++
// TAO based client, communicating using the IIOP protocol, and not using a NameService.
//
// This is a simple c++ client using ACE/TAO.  This client is complementary to the following
// example servers:
//	1.	DotNetAdderServer - A C# IIOPNet server.
//
// This  C++ TAO client uses an SLB.ExampleInterfaces.IAdder object on the remote C# IIOPNet server.
//
// To use this example:
//	1.	Start the C# .Net IIOP Server:  DotNetAdderServer.exe
//	2.	Start the C++ TAO Client: TAODirectAdderClient.exe -ORBInitRef IAdder=iiop://localhost:12345/IAdder

#include "ExampleInterfacesC.h"
#include <ace/streams.h>

int main( int argc, char *argv[] )
{
  try 
  {
    // Initialize CORBA Object Request Broker
    CORBA::ORB_var orb = CORBA::ORB_init( argc, argv );

	// Instead of using the TAO NameService, resolve the desired interface directly, based
	// upon the -ORBInitRef passed in on the command line and used to initialize the ORB.
	// For example: -ORBInitRef IAdder=iiop://remotehost:12345/IAdder
	CORBA::Object_var obj = orb->resolve_initial_references("IAdder");

    // Narrow to the requested object, and confirm that the object is of the required type
	ExampleInterfaces::IAdder_var iAdder = ExampleInterfaces::IAdder::_narrow(obj.in());
    if (CORBA::is_nil(iAdder.in())) 
	{
      cerr << "Could not narrow to an IAdder reference" << endl;
      return 1;
    }

	// Now use the remote object...
	cout << "Using a remote object that implements the IAdder interface..." << endl;
	cout << endl;
	double number1 = 0;
	double number2 = 0;
	double sum = 0;
	while (true)
	{
		cout << "Enter the first number: ";
		cin >> number1;
		cout << "Enter the second number: ";
		cin >> number2;
		sum = iAdder->add(number1, number2);
		cout << "The sum is: " << sum << endl;
		cout << "------------------" << endl;
	}


  }
  catch ( CORBA::Exception& ex ) {
    cerr << "Caught a CORBA::Exception: " << ex << endl;
    return 1;
  }
  
  return 0;
}
