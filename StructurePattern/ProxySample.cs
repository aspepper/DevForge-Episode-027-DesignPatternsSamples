/* 
The Proxy pattern provides a substitute or access point for another 
object to control access to it. It is useful for controlling, modifying, 
or managing access to an object in various ways.
*/
namespace DesignPatternsSamples.StructurePattern;

// Subject interface that defines the Request method
public interface ISubject
{
    void Request();
}

// Concrete implementation of the RealSubject (the house)
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("Request handled by RealSubject");
    }
}

// Implementation of the Proxy (the gate)
public class Proxy : ISubject
{
    private RealSubject? realSubject;

    public void Request()
    {
        realSubject ??= new RealSubject();
        Console.WriteLine("Request handled by Proxy");
        realSubject.Request();
    }
}
