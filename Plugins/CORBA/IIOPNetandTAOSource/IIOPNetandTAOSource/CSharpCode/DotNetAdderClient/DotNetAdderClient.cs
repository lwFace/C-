/// DotNetAdderClient.cs
/// 
/// Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
/// 02 November 2005
/// 
/// This is an example that demonstrates a technique for using an interface (IAdder),
/// that is exposed by a known server.  Any class (in this case Adder) might implement IAdder, 
/// so we look for the interface on the server, and do not look for a particular implementation. 
/// In this example, we are using an iiop channel as provided by the IIOPNet package written by 
/// Dominic Ullmann <dullmann@users.sourceforge.net> and Patrik Reali <patrik_reali@users.sourceforge.net>.
/// This client connect directly to the server, as is normal for .NET clients, rather than connecting
/// through a Naming Service.
/// 
/// This example client is a compliment to the following example servers:
/// 1. DotNetAdderServer - a .Net Server based upon an Adder class that implements the IAdder interface.
/// 

using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

// ..\IIOPChannel.dll
using Ch.Elca.Iiop;
using Ch.Elca.Iiop.Services;

// from project ExampleInterfaces.dll
using SLB.ExampleInterfaces;

namespace SLB.Examples
{

	/// <summary>
	/// This client accepts two numbers from the user at the console, and then
	/// calls a remote object that exposes the IAdder interface in order to add them and
	/// return the result.
	/// 
	/// Usage is: DotNetAdderClient.exe host port
	/// </summary>
    public class DotNetAdderClient 
	{
		private static string host = "localhost";	//default host
		private static int port = 12345;			//default port


		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args">Command line arguments: host port</param>
		[STAThread]
        public static void Main(string[] args) 
		{
            try 
			{
				ParseCommandLineArguments(args);

                // Register the Channel...
                IiopClientChannel channel = new IiopClientChannel();	//assign port automatically
                ChannelServices.RegisterChannel(channel);

                // Get the reference to the servant object using the interface...
                IAdder adder = (IAdder)RemotingServices.Connect(typeof(IAdder), "iiop://" + host + ":" + port + "/IAdder");
                
                // Use the servant...
				InteractWithUser(adder);

            } 
			catch (Exception e)
			{
				// catch specific exceptions...
				if(e.Message=="Usage")
				{
					Console.WriteLine("Usage: NetAdderClient host port ");
				}
				else	// catch everything else.
				{
					Console.WriteLine("An Exception was caught in NetAdderClient: " + e);
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