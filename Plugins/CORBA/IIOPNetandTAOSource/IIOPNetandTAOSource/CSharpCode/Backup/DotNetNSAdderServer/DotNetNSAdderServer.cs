/// DotNetNSAdderServer.cs
/// 
/// Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
/// 22 November 2005
/// 
/// This is an example that demonstrates a technique for combining an interface (IAdder),
/// an implimentation (Adder), and a console based, TAO NameService-using server application (DotNetNSAdderServer) 
/// using the IIOPNet package written by Dominic Ullmann <dullmann@users.sourceforge.net>
/// and Patrik Reali <patrik_reali@users.sourceforge.net>.
/// 
/// This example server is a compliment to the following example clients:
/// 1. DotNetNSAdderClient - a .NET client that consumes the IAdder interface through a TAO Naming Service.
/// 2. TAOAdderClient - a C++ TAO client that consumes the IAdder interface through a TAO Naming Service.
/// 
/// This example server is interchangable with the following example servers:
/// 1. TAOAdderServer - a C++ TAO server that publishes the IAdder interface through a TAO Naming Service.
/// 

using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Threading;

// from ..\IIOPChannel.dll
using Ch.Elca.Iiop; 
using Ch.Elca.Iiop.Services; 
using omg.org.CosNaming; 

// from project IIOPExampleInterfaces.dll
using SLB.ExampleInterfaces;


namespace SLB.ExampleServers
{

	/// <summary>
	/// The adder implementation class.
	/// </summary>
	public class Adder: MarshalByRefObject, IAdder 
	{
		public override object InitializeLifetimeService() 
		{
			// live forever
			return null;
		}
		
		public double add(double arg1, double arg2) 
		{
			return arg1 + arg2;
		}
	}

	/// <summary>
	/// This .Net Server class object publishes an SLB.ExampleInterfaces.IAdder implementation
	/// and registers it on a TAO Naming Service using the iiop protocol.
	/// </summary>
	public class DotNetAdderServer 
	{

//		private static string host = "localhost";	//FAILS - seems to be associated with connecting to running Naming Service...
		private static string host = "slb001";		//use default named or IP host
		private static int port = 12345;			//default port


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args) 
		{
			try
			{
				ParseCommandLineArguments(args);

				// register the channel
				IiopChannel chan = new IiopChannel(0);	// assign port automatically
				ChannelServices.RegisterChannel(chan);

				// Access the COS naming service (NameService)...
				CorbaInit init = CorbaInit.GetInit();
				NamingContext nameService = init.GetNameService(host, port);

				// Bind the IDL-defined module (which maps to a .Net namespace)...
				NameComponent[] moduleName = new NameComponent[] {new NameComponent("ExampleInterfaces", "")};
				NamingContext nameSpace = nameService.bind_new_context(moduleName);

				// Bind the IDL-defined interface (which maps to a .NET interface class)
				NameComponent[] interfaceName = new NameComponent[] {new NameComponent("IAdder", "")};
				Adder interfaceImplimentation = new Adder();
				nameSpace.bind(interfaceName,interfaceImplimentation);


				Console.WriteLine(".Net IAdder Server is Running...");
				Console.WriteLine("Clients can connect using the TAO NamingService on Host:" + host + " Port:" + port.ToString());
				Thread.Sleep(Timeout.Infinite);
			}
			catch (Exception e)
			{
				// catch specific exceptions...
				if(e.Message=="Usage")
				{
					Console.WriteLine("Usage: DotNetNSAdderServer host port ");
				}
				else	// catch everything else.
				{
					Console.WriteLine("An Exception was caught in DotNetNSAdderServer: " + e);
				}
			}
		}

		/// <summary>
		/// Parse the command line for host and port.
		/// </summary>
		/// <param name="args">The command line arguments.</param>
		private static void ParseCommandLineArguments(string[] args)
		{
			if(args.Length > 0)
			{
				host = args[0];
			}
			if(args.Length > 1)
			{
				port = Int32.Parse(args[1]);
			}
			if(args.Length > 2)
			{
				throw(new Exception("Usage"));
			}
		}

	}
}


