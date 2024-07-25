namespace DesignPatternsSamples.StructurePattern;

// Interface for the Implementor (the concept of controlling the TV)
public interface IImplementor
{
    void OperationImp(); // Method for the specific operation
}

// Concrete implementation of the Implementor (a remote control that changes the channel)
public class ConcreteImplementorA : IImplementor
{
    public void OperationImp() { /* Specific implementation, like changing the channel */ }
}

// Abstraction (the remote control itself)
public class Abstraction
{
    protected IImplementor implementor;

    public Abstraction(IImplementor implementor)
    {
        this.implementor = implementor;
    }

    public void Operation()
    {
        implementor.OperationImp(); // Uses the Implementor to perform the operation
    }
}
