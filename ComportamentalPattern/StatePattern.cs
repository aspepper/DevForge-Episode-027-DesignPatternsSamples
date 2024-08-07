/*
The State pattern allows an object to change its behavior
when its internal state changes. Think of it as a vending
machine that behaves differently depending on whether you
have inserted money or not.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// State interface
public interface IState
{
    void Handle(ContextState context);
}

// Concrete state class
public class HasMoneyState : IState
{
    public void Handle(ContextState context)
    {
        Console.WriteLine("Dispensing product...");
        context.SetState(new NoMoneyState());
    }
}

public class NoMoneyState : IState
{
    public void Handle(ContextState context)
    {
        Console.WriteLine("Waiting for money...");
    }
}

// Context class
public class ContextState(IState state)
{
    private IState state = state;

    public void SetState(IState state)
    {
        this.state = state;
    }

    public void Request()
    {
        state.Handle(this);
    }
}