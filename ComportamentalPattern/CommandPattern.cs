namespace DesignPatternsSamples.ComportamentalPattern;

// Command interface
public interface ICommand
{
    void Execute();
}

// Concrete command class
public class TurnOnCommand(TV tv) : ICommand
{
    private TV tv = tv;

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