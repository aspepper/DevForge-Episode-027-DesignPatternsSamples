namespace DesignPatternsSamples.StructurePattern;

// Abstract class Component (base class for all components)
public abstract class Component
{
    public abstract void Operation(); // Abstract method to be implemented by concrete components
}

// Concrete implementation of a Component
public class ConcreteComponent : Component
{
    public override void Operation() { /* Implementation of the operation */ }
}

// Abstract class Decorator that also inherits from Component
public abstract class Decorator : Component
{
    protected Component? component; // Holds a reference to a Component

    public void SetComponent(Component component)
    {
        this.component = component; // Sets the component to be decorated
    }

    public override void Operation()
    {
        component?.Operation(); // Calls the operation of the component, if it exists
    }
}

// Concrete implementation of a Decorator
public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation(); // Calls the operation of the decorated component
        // Add additional behavior.
    }
}

