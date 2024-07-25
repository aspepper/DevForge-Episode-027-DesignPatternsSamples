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
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }
        Console.WriteLine("Request handled by Proxy");
        realSubject.Request();
    }
}
