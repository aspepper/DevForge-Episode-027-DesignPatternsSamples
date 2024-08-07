/*
The Chain of Responsibility pattern allows a request to pass
through a chain of objects until one of them processes it.
Think of it as a technical support request that goes through
various levels until it finds someone who can resolve it.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Abstract handler class
public abstract class Handler
{
    protected Handler? nextHandler;

    public void SetNext(Handler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(int request);
}

// Concrete handler class
public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
        {
            Console.WriteLine("ConcreteHandler1 handled the request");
        }
        else
        {
            nextHandler?.HandleRequest(request);
        }
    }
}