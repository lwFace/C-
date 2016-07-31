 /*
 nslister.cpp
 -------------
 This is a simple NameService using client using ACE/TAO.

 For convenience, it has been produced from  stubs and skeletons produced by tao_idl from 
 the nslister.idl (which is a clone of simple.idl, for those who care).  Only the client 
 code is relevant for this project, but the other generated files have been left 
 in because they cause no harm and it was more convenient than trying to trace and
 consolidate the dependencies that might (or might not) exist.

 This client reworks the nslist Naming Service Listing Utility provided with/for ACE/TAO 
 which was tagged as follows:

  nslist.cpp,v 1.29 2005/02/11 14:44:05 elliott_c Exp
  @author  Thomas Lockhart, NASA/JPL <Thomas.Lockhart@jpl.nasa.gov>
  @date 1999-06-03

 This utility provides a reduced functionality from nslist, in that it does not accomodate
 command line switches to display IOR's for object references.  It does, however, display
 the IOR of the NameService itself.  Also, there is some additional error handling code and
 an extended list of protocols that will be reported.  In addition, the output has been
 modified to make the relationship between the modules/namespaces and interfaces/classes 
 of the IDL's that are being exposed by the Naming Service more explicit.
 
 The main merit of this code is that it is CORBA-centric, rather than ACE-centric like the
 original nslist.  This may make this code easier to understand, maintain, and extend - which
 will hopefully benefit programmers without ACE experience.

 @file nslister.cpp
 @author Stephen Bogner, DRDC Suffield <Stephen.Bogner@drdc-rddc.gc.ca>
 @date 2005-10-30
 
 */


#include "nslisterC.h"
#include <orbsvcs/CosNamingC.h>
#include <orbsvcs/Naming/Naming_Client.h>
#include <ace/streams.h>
#include "tao/Endpoint.h"
#include "tao/Profile.h"
#include "tao/Stub.h"
#include "tao/ORB_Constants.h"

CORBA::ORB_var orb;
static void list_context(CosNaming::NamingContext_var nc);

// Get the protocol that is being used by the NamingService for the entry.
static void GetProtocol(CORBA::ULong tag, CORBA::String_var& tag_string)
{
  if (tag == IOP::TAG_INTERNET_IOP)
  {
      tag_string = "IIOP";
  }
  else if (tag == TAO_TAG_UIOP_PROFILE)
  {
      tag_string = "UIOP";
  }
  else if (tag == TAO_TAG_SHMEM_PROFILE)
  {
      tag_string = "SHMEM";
  }
  else if (tag == TAO_TAG_DIOP_PROFILE)
  {
      tag_string = "UDP";
  }
  else if (tag == TAO_TAG_UIPMC_PROFILE)
  {
      tag_string = "IP Multicast";
  }
  else if (tag == TAO_TAG_SCIOP_PROFILE)
  {
      tag_string = "SCIOP";
  }
  else if (tag == TAO_TAG_NSKFS_PROFILE)
  {
      tag_string = "Tandem (HP) File System";
  }
  else if (tag == TAO_TAG_NSKPW_PROFILE)
  {
      tag_string = "Tandem (HP) Pathsend";
  }
  else if (tag == IPDSFIELD_DSCP_DEFAULT)
  {
      tag_string = "Default DiffServ CodePoint";
  }
  else
      tag_string = "Unknown tag: " + tag;
}


// Display the protocol and endpoint of the entry in the NameService.
static void display_endpoint_info(CORBA::Object_ptr obj)
{
  if (CORBA::is_nil(obj))
  {
	  cout << "Nil" << endl;
	  return;
  }

  TAO_Stub *stub = obj->_stubobj();
  if (!stub)
  {
	  cout << "Invalid TAO Stub" << endl;
	  return;
  }

  TAO_Profile* profile = stub->profile_in_use();
  if (!profile)
  {
	  cout << "Invalid TAO Profile" << endl;
      return;
  }

  TAO_Endpoint* endpoint = profile->endpoint();
  if (!endpoint)
  {
	  cout << "Invalid TAO Endpoint" << endl;
	  return;
  }

  CORBA::ULong tag = endpoint->tag();
  CORBA::String_var tag_name;
  GetProtocol(tag, tag_name);

  char buf[255];
  if (endpoint->addr_to_string(buf, 255) < 0)
  {
	  cout << "Could not put Endpoint Address into a string." << endl;
	  return;
  }

  cout << "\t\t" << tag_name << "\t\t" << buf << endl;
}


// Display NameService entries from a finite list.
static void show_chunk(CosNaming::NamingContext_var nc, const CosNaming::BindingList &bl)
{
  for (CORBA::ULong i = 0;i < bl.length(); i++)
  {
    CosNaming::Name name;
    name.length (1);
    name[0].id = CORBA::string_dup(bl[i].binding_name[0].id);
    name[0].kind = CORBA::string_dup(bl[i].binding_name[0].kind);

    CORBA::Object_var obj = nc->resolve(name);

    // If this is a context node, follow it down to the next level...
    if (bl[i].binding_type == CosNaming::ncontext)
    {
		cout << name[0].id << endl;
		CosNaming::NamingContext_var xc = CosNaming::NamingContext::_narrow(obj.in());
		list_context(xc);
    }
      
    else  // Mark this node as a reference binding_type == CosNaming::nobject
    {
	//	cout << "-----------\t ------------- \t -------- \t --------" << endl;
		cout << "           \t " << name[0].id;
		
		display_endpoint_info(obj.in());
    }
  }
}


// Display NameService entries from an unbounded list.
static void list_context(CosNaming::NamingContext_var nc)
{
  CosNaming::BindingIterator_var it;
  CosNaming::BindingList_var bl;
  const CORBA::ULong CHUNK = 100;

  nc->list(CHUNK, bl, it );

  show_chunk(nc, bl.in());

  if (!CORBA::is_nil(it.in()))
  {
    CORBA::Boolean more;

    do
    {
      more = it->next_n(CHUNK, bl);
      show_chunk(nc, bl.in());
    }
    while(more);
  }
}

// The entry point of the application.
int main( int argc, char *argv[] )
{
  try 
  {
    // Initialize orb
    CORBA::ORB_var orb = CORBA::ORB_init( argc, argv );

	// Find the Naming Service
	CORBA::Object_var naming_obj = orb->resolve_initial_references("NameService");
	CosNaming::NamingContext_var root = CosNaming::NamingContext::_narrow(naming_obj.in());
	// If the calls above don't succeed, an exception should be thrown.  Just in case it isn't...
	if (CORBA::is_nil(naming_obj.in()) || CORBA::is_nil(root.in()))
	{
		cout << "Naming Service has not been found!" << endl;
		return 0;
	}

	// Now list the contents of the Naming Service.
	CORBA::String_var str = orb->object_to_string(root.in());

	cout << "--- nslister ---" << endl;
	cout << endl;
	cout << "Naming Service: " << endl;
	cout << endl;
	cout << str.in() << endl; // show the stringified IOR for the Naming Service...
	cout << endl;
	cout << "IDL Module \t IDL Interface \t\tProtocol \tEndpoint" << endl;
	cout << "(Namespace)\t (Class)       \t\t         \t        " << endl;
	cout << "-----------\t ------------- \t\t-------- \t--------" << endl;

	list_context(root);
  }
  // catch specific failures...
  catch (CORBA::COMM_FAILURE& ex)
  {
	  cerr << "A communication failure has occurred: " << ex << endl;
	  cerr << "Try pinging the host to confirm that a connection is possible." << endl;
	  return 1;
  }
  catch (CORBA::TRANSIENT& ex)
  {
	  cerr << "A transient failure has occurred: " << ex << endl;
	  cerr << "Name Service may not have been started or may be temporarily unavailable." << endl;
	  cerr << endl;
	  cerr << "To inspect a specific non-multicast Name Service use: " << endl;
	  cerr << "nslister -ORBInitRef NameService=iiop://thehost:2809/NameService " << endl;
	  return 1;
  }
  // catch all other system exceptions...
  catch (CORBA::SystemException& ex)
  {
	  cerr << "A CORBA System Exception was caught in nslister: " << endl;
	  cerr << ex << endl;
	  return 1;
  }
  // catch all CORBA non-system exceptions...
  catch ( CORBA::Exception& ex ) 
  {
	  cerr << "A CORBA Exception was caught in nslister: " << endl;
 	  cerr << ex << endl;
	  return 1;
  }
  
  return 0;
}
