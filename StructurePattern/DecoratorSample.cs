/* 
The Decorator pattern allows you to add responsibilities to objects 
in a flexible and dynamic way, without modifying their basic structure.
 */
namespace DesignPatternsSamples.StructurePattern;

// Abstract class Component (base class for all components)
public abstract class ComponentDecorator
{
    // Abstract method to be implemented by concrete components
    public abstract void Operation();
}

// Concrete implementation of a Component
public class ConcreteComponent : ComponentDecorator
{
    public override void Operation() 
    { 
        /* Implementation of the operation */ 
    }
}

// Abstract class Decorator that also inherits from Component
public abstract class Decorator : ComponentDecorator
{
    // Holds a reference to a Component
    protected ComponentDecorator? component; 

    public void SetComponent(ComponentDecorator component)
    {
        // Sets the component to be decorated
        this.component = component; 
    }

    public override void Operation()
    {
        // Calls the operation of the component, if it exists
        component?.Operation(); 
    }
}

// Concrete implementation of a Decorator
public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        // Calls the operation of the decorated component
        base.Operation(); 
        // Add additional behavior.
    }
}