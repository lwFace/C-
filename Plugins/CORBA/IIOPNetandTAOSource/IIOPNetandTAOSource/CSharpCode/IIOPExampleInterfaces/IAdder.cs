/// IAdder.cs
///
/// Stephen Bogner <Stephen.Bogner@drdc-rddc.gc.ca>
/// 02 November 2005
/// 
/// One of a set of interfaces that are used in the examples and tutorials, collected into one library.
///
using System;
using System.Runtime.Remoting;

namespace SLB.ExampleInterfaces
{
    /// <summary>The IAdder interface accepts two doubles and returns a double.</summary>
    public interface IAdder
	{
        double add(double arg1, double arg2);
    }
}
