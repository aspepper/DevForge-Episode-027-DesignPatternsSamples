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
    {
        return new ConcretePrototype { Id = this.Id, Name = this.Name }; // Creates a copy of the object
    }
}
