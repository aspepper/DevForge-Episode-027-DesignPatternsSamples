/*
The Composite pattern allows you to treat individual objects 
and compositions of objects uniformly, making it easier to 
handle hierarchical structures.
*/
namespace DesignPatternsSamples.StructurePattern;

// Abstract base class representing both individual objects and compositions
public abstract class ComponentComposite
{
    // Abstract method to be implemented by leaf and composite classes
    public abstract void Operation();
}

// Leaf class representing individual objects in the composition
public class Leaf : ComponentComposite
{
    // Implementation for the operation specific to the leaf
    public override void Operation() 
    { 
        /* Implementation for leaf */ 
    }
}

// Composite class representing compositions of objects
public class Composite : ComponentComposite
{
    // List to store child components
    private readonly List<ComponentComposite> children = [];

    // Method to add a child component to the composite
    public void Add(ComponentComposite component) 
    { 
        children.Add(component); 
    }

    // Method to remove a child component from the composite
    public void Remove(ComponentComposite component) 
    { 
        children.Remove(component); 
    }

    // Implementation for the operation, iterates 
    // over children and calls their operation
    public override void Operation()
    {
        foreach (var child in children)
        {
            child.Operation();
        }
    }
}
