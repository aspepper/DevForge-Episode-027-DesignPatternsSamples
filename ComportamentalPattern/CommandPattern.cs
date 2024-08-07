/*
The Command pattern turns a request into an object, allowing
you to parameterize clients with queues of requests, log requests,
or implement operations that can be undone. Think of it as a remote
control that stores commands to turn on the TV, increase the volume,
etc.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Command interface
public interface ICommand
{
    void Execute();
}

// Concrete command class
public class TurnOnCommand(TV tv) : ICommand
{
    private readonly TV tv = tv;

    public void Execute()
    {
        tv.TurnOn();
    }
}

// Receiver class
public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV is on");
    }
}