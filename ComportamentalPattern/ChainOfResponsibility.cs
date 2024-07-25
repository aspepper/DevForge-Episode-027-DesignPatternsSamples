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