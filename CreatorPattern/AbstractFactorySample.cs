/*
The Abstract Factory pattern is like a factory that can create various related things. Imagine you have a furniture
factory that can make both chairs and tables. Depending on the specific factory, you can create a modern furniture
set or a classic furniture set. The Abstract Factory provides an interface (a blueprint) for creating these families
of related objects (like chairs and tables) without specifying exactly which concrete classes (specific types) will
be created.
*/
namespace DesignPatternsSamples.CreatorPattern;

// We define an interface for the Abstract Factory (the furniture factory)
public interface IAbstractFactory
{
    // Method to create a chair
    IProductA CreateProductA();

    // Method to create a table
    IProductB CreateProductB(); 
}

// Here is an interface for Product A (chair)
public interface IProductA
{
    void SitOn();
}

// Here is an interface for Product B (table)
public interface IProductB
{
    void PlaceItemsOn();
}

// This is a concrete implementation of a modern chair
public class ProductA1 : IProductA
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair!");
    }
}

// This is a concrete implementation of a modern table
public class ProductB1 : IProductB
{
    public void PlaceItemsOn()
    {
        Console.WriteLine("Placing items on a modern table!");
    }
}

// This is a concrete factory that creates modern furniture
public class ConcreteFactory1 : IAbstractFactory
{
    // Creates a modern chair
    public IProductA CreateProductA() => new ProductA1();
    
    // Creates a modern table
    public IProductB CreateProductB() => new ProductB1(); 
}
