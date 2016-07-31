/// DotNetNSAdderClient.cs
/// 
/// Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
/// 02 November 2005
/// 
/// This example demonstrates a C# IIOPNet client using a C++ ACE/TAO server, with
/// communication passing through a TAO Naming Service.
/// 
/// This example consumes an IAdder interface.  The IAdder interface is defined
/// in the ExampleInterfaces.idl for C++ usage (via tao_idl -GI ExampleInterfaces.idl),
/// and in the ExampleInterfaces.dll for .NET usage.
/// 
/// A few key points about this example are:
///		1.	A named host (or ip-address host) must be used to connect to the NameService.
///			If "localhost" is used, an omg.org.CORBA.COMM_FAILURE is raised.  (My development
///			machine is called "slb001", so that is what I use in this code.  Of course, you
///			should substitute the name of your own machine, either in the code or at the command line...)
///		2.	module definitions in IDL, which map to namespace's in .NET, are treated as
///			NamingContext objects on the TAO NameService. It is necessary to resolve all
///			of the way through the nested set of NamingContext's (the omg.org.CosNaming.BindingType.ncontext
///			types) to get to the desired interface (the omg.org.CosNaming.BindingType.nobject types).
///		3.	The unusual single-word exception messages being thrown are a setup to a switch-based exception
///			handling technique that is not implimented in this simplistic example.
///			
///	This client is complementary to the following servers:
///		1.	DotNetNSAdderServer - an IIOP.NET server that registers a IAdder interface on a TAO Naming Service.
///		2.	TAOAdderServer - a TAO server that publishes an IAdder interface on a TAO Naming Service.
///		
///	This client is interchangable with the following clients:
///		1.	TAOAdderClient - a TAO client that consumes an IAdder interface from a TAO Naming Service.
///			
///	To use this example:
///		1.	Start the TAO NamingService: %TAO_ROOT%\orbsvcs\Naming_Service\Release\Naming_Service.exe %NS%
///			where, for example, %NS% = -m 0 -ORBEndpoint iiop://slb001:2809 -ORBDebugLevel 4
///		2a.	Start the C++ TAO-based Server: TAOAdderServer.exe %NSC%
///			where, for example, %NSC% = -ORBInitRef NameService=iiop://slb001:2809/NameService
///		2b. Start the C# IIOP.NET-based Server: DotNetNSAdderServer.exe slb001 2809
///		3.	Start the C# IIOPNet-based Client: DotNetNSAdderClient.exe slb001 2809 
/// 

using System; 
using System.IO; 
using System.Runtime.Remoting; 
using System.Runtime.Remoting.Channels;

// from ..\IIOPChannel.dll
using Ch.Elca.Iiop; 
using Ch.Elca.Iiop.Services; 
using omg.org.CosNaming; 

// from project IIOPExampleInterfaces.dll
using SLB.ExampleInterfaces;

namespace SLB.ExampleClients
{
	/// <summary>
	/// A simple NameService using client that connects to an ACE/TAO server through a TAO NameService.
	/// This client consumes a remote SLB.ExampleInterfaces.IAdder interface.
	/// </summary>
	class DotNetNSAdderClient
	{
//		private static string host = "localhost";	// FAILS - must use a named or ip-address host.
		private static string host = "slb002";		// named host
		private static int port = 2809;				// OMG default port for iiop

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			try 
			{
				// Process the command line...
				ParseArgs(args);
			
				// Register the channel...
				IiopClientChannel channel = new IiopClientChannel();	// assign port automatically
				ChannelServices.RegisterChannel(channel);
 
				// Access the COS naming service (NameService)...
				CorbaInit init = CorbaInit.GetInit();
				NamingContext nameService = init.GetNameService(host, port);

				// Access the IDL-defined module (which maps to a .Net namespace)...
				NameComponent[] moduleName = new NameComponent[] {new NameComponent("ExampleInterfaces", "")};
				NamingContext nameSpace = (NamingContext)nameService.resolve(moduleName);

				// Access the IDL-defined interface (which maps to a .NET interface class)
				NameComponent[] interfaceName = new NameComponent[] {new NameComponent("IAdder", "")};
				SLB.ExampleInterfaces.IAdder servant = (SLB.ExampleInterfaces.IAdder)nameSpace.resolve(interfaceName);

				// Use the servant...
				InteractWithUser(servant);

			} 
			catch (Exception e) 
			{
				// usage exception
				if(e.Message == "Usage")
				{
					Console.WriteLine("Usage: Client.exe <string theNameServiceHost> <int theNameServicePort>");
				}
				// localhost exception
				else if(e.Message == "localhost")
				{
					Console.WriteLine("Usage: The NameService host must be a named host (ex. myhost) or an ip-address host (ex. 123.123.123.123).");
					Console.WriteLine("       The NameService host cannot be \"localhost\".");
				}
				else	// another exception
				{
					Console.WriteLine("Exception: " + e);
				}
			}
		}

		/// <summary>
		/// This method parses the command line arguments according to the expected usage:
		/// client.exe theNameServiceHost theNameServicePort
		/// If no arguments are passed, then it uses the defaults (namedHost 2809).
		/// </summary>
		/// <param name="args">The array of commandline arguments.</param>
		private static void ParseArgs(string[] args) 
		{
			if (args.Length > 0) 
			{
				host = args[0];
				if (host == "localhost")
				{
					throw(new Exception("localhost"));
				}
			}
			if (args.Length > 1) 
			{
				port = Int32.Parse(args[1]);
			}
			if (args.Length > 2)
			{
				throw(new Exception("Usage"));
			}
		}
		/// <summary>
		/// Some really simplistic user interaction with the remote servant object, which is
		/// passed into the interaction as a parameter.
		/// </summary>
		/// <param name="adder">The remote servant object - in this case an IAdder interface.</param>
		private static void InteractWithUser(IAdder adder)
		{
			string goAgain = "Y";
			while(goAgain == "Y" |goAgain == "y")
			{
				
				Console.WriteLine("Input the two numbers that you would like to sum.");
				Console.WriteLine("First Number:");
				double number1 = Double.Parse(Console.ReadLine());
				Console.WriteLine("Second Number:");
				double number2 = Double.Parse(Console.ReadLine());
				// use the remote IAdder...
				double result = adder.add(number1, number2);
				Console.WriteLine("The sum is: " + result);
				Console.WriteLine("Go Again? (y/n)");
				goAgain = Console.ReadLine();
			}
		}
	}
}
