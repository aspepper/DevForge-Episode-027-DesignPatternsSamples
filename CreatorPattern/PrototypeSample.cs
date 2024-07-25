/*
The Prototype pattern is used to create new objects by copying an existing object, known as the prototype.
Imagine you have a clay model figure and want to make several identical figures. Instead of creating each
figure from scratch, you make a copy of the original figure. This is what the Prototype pattern does: it
creates new objects by copying a prototype.
*/
namespace DesignPatternsSamples.CreatorPattern;

// Interface that defines the Clone method (to copy the object)
public interface IPrototype
{
    IPrototype Clone(); // Method to clone the object
}

// Concrete class that implements the Clone method
public class ConcretePrototype : IPrototype
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IPrototype Clone()
        // Creates a copy of the object
        => new ConcretePrototype { Id = this.Id, Name = this.Name }; 
}
