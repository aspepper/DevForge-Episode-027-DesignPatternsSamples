namespace DesignPatternsSamples.ComportamentalPattern;

// Observer interface that defines the Update method
public interface IObserver
{
    void Update(); // Method to update the observer
}

// Subject interface that defines methods to attach, detach, and notify observers
public interface ISubject
{
    void Attach(IObserver observer); // Method to add an observer
    void Detach(IObserver observer); // Method to remove an observer
    void Notify(); // Method to notify all observers
}

// Concrete implementation of the Subject
public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new();

    public void Attach(IObserver observer) 
    { 
        observers.Add(observer); 
    }

    public void Detach(IObserver observer) 
    { 
        observers.Remove(observer); 
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(); // Notify each observer
        }
    }
}