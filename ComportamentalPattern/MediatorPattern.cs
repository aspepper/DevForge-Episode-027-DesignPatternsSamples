namespace DesignPatternsSamples.ComportamentalPattern;

// Mediator interface
public interface IMediator
{
    void Notify(object sender, string ev);
}

// Concrete mediator class
public class ConcreteMediator : IMediator
{
    private Colleague1 colleague1;
    private Colleague2 colleague2;

    public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
    {
        this.colleague1 = colleague1;
        this.colleague1.SetMediator(this);
        this.colleague2 = colleague2;
        this.colleague2.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Console.WriteLine("Mediator reacts on A and triggers following operations:");
            colleague2.DoC();
        }
        if (ev == "D")
        {
            Console.WriteLine("Mediator reacts on D and triggers following operations:");
            colleague1.DoB();
        }
    }
}

// Base colleague class
public class BaseColleague
{
    protected IMediator? mediator;

    public void SetMediator(IMediator mediator)
    {
        this.mediator = mediator;
    }
}

// Concrete colleague class 1
public class Colleague1 : BaseColleague
{
    public void DoA()
    {
        Console.WriteLine("Colleague1 does A.");
        mediator?.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Colleague1 does B.");
    }
}

// Concrete colleague class 2
public class Colleague2 : BaseColleague
{
    public void DoC()
    {
        Console.WriteLine("Colleague2 does C.");
    }

    public void DoD()
    {
        Console.WriteLine("Colleague2 does D.");
        mediator?.Notify(this, "D");
    }
}