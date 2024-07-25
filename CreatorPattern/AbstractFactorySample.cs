namespace DesignPatternsSamples.CreatorPattern;

// We define an interface for the Abstract Factory (the furniture factory)
public interface IAbstractFactory
{
    IProductA CreateProductA(); // Method to create a chair
    IProductB CreateProductB(); // Method to create a table
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
    public IProductA CreateProductA() => new ProductA1(); // Creates a modern chair
    public IProductB CreateProductB() => new ProductB1(); // Creates a modern table
}
