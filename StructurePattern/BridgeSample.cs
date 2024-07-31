/*
The Bridge pattern allows you to change the abstraction and implementation 
independently, providing flexibility and code reuse.
*/
namespace DesignPatternsSamples.StructurePattern;

// Interface for the Implementor (the concept of controlling the TV)
public interface IImplementor
{
    // Method for the specific operation
    void OperationImp(); 
}

// Concrete implementation of the Implementor (a remote control that changes the channel)
public class ConcreteImplementorA : IImplementor
{
    public void OperationImp() 
    { 
        /* Specific implementation, 
        like changing the channel */ 
    }
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
        // Uses the Implementor to perform the operation
        implementor.OperationImp(); 
    }
}
