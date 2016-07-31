This directory contains the source material necessary to build the ACE/TAO C++ projects for the following:

1. TAOAdderServer - An ACE/TAO server that serves an SLB.ExampleInterfaces.IAdder Interface.
2. TAOAdderClient - An ACE/TAO client that consumes the IAdder interface published by ACE/TAO TAOAdderServer.
3. TAODirectAdderClient - An ACE/TAO client that consumes the IAdder interface published by the IIOP.NET DotNetAdderServer.

To compile these projects do the following:

1. Put the project into a Linux (or Windows) Directory.
2. Generate the C++ Stub and Skeleton files for the server and clients by running the tao_idl utility as follows (note GI option is not required): tao_idl ExampleInterfaces.idl
3. Generate the gc++ projects on Linux (or the Visual Studio .NET 2003 projects on Windows) by running the Make Workspace Creator script (mwc.pl) as follows:
	for Linux: mwc.pl -type gnuace
	for Windows: mwc.pl -type VC71
4. On Linux, compile the project using "make".
5. On Windows, open the TAOAdder solution, and build it.


Once the project is built (on either system) the programs can be run by doing the following:

1. Start the TAO Naming Service:  ./Naming_Service -m 0 ORBEndpoint iiop://localhost:2809 -ORBDebugLevel 4
2. Start the TAO Server: ./TAOAdderServer -ORBInitRef NameService=iiop://localhost:2809/NameService
3. Start the TAO Client: ./TAOAdderClient -ORBInitRef NameService=iiop://localhost:2809/NameService

Assuming that the IIOP.NET DotNetAdderServer has been started on a windows machine called mywinhost, at port 12345;

4. Start the TAO Direct Adder Client: ./TAODirectAdderClient -ORBInitRef IAdder=iiop://mywinhost:12345/IAdder

