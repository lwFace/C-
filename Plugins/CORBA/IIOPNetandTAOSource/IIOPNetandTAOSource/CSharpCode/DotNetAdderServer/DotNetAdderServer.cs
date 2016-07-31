/// DotNetAdderServer.cs
/// 
/// Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
/// 02 November 2005
/// 
/// This is an example that demonstrates a technique for combining an interface (IAdder),
/// an implimentation (Adder), and a console based server application (DotNetAdderServer) 
/// using the IIOPNet package written by Dominic Ullmann <dullmann@users.sourceforge.net>
/// and Patrik Reali <patrik_reali@users.sourceforge.net>. Clients connect to this server
/// directly, rather than through a Naming Service.
/// 
/// This example server is a compliment to the following example clients:
/// 1. DotNetAdderClient - a .NET client that consumes the IAdder interface.
/// 2. TAODirectAdderClient - a C++ TAO client that consumes the IAdder interface.
/// 

using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Threading;

// ..\IIOPChannel.dll
using Ch.Elca.Iiop;

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
    /// using the iiop protocol.
    /// </summary>
    public class DotNetAdderServer 
	{

		private static string host = "localhost";	//default host
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
				IiopChannel chan = new IiopChannel(port);
				ChannelServices.RegisterChannel(chan);
		
				Adder adder = new Adder();
				string objectURI = "IAdder";	// the adder object is used, but only the IAdder interface is seen...
				RemotingServices.Marshal(adder, objectURI);
			
				Console.WriteLine(".Net IAdder Server is Running...");
				Console.WriteLine("Clients can connect using iiop://" + host + ":" + port.ToString() + "/" + objectURI);
				Thread.Sleep(Timeout.Infinite);
			}
			catch (Exception e)
			{
				// catch specific exceptions...
				if(e.Message=="Usage")
				{
					Console.WriteLine("Usage: DotNetAdderServer host port ");
				}
				else	// catch everything else.
				{
					Console.WriteLine("An Exception was caught in DotNetAdderServer: " + e);
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

