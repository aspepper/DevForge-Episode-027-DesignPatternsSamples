namespace DesignPatternsSamples.CreatorPattern;

// We define an interface (a blueprint) for the Product
public interface IProduct
{
    void Use();
}

// Here is an example of a Concrete Product (a specific toy)
public class ConcreteProduct : IProduct
{
    public void Use()
    {
        Console.WriteLine("Using the concrete product!");
    }
}

// This is the abstract Creator class (the toy factory)
public abstract class Creator
{
    // The abstract FactoryMethod (the machine's button)
    public abstract IProduct FactoryMethod();

    // A method that uses the created product
    public void AnOperation()
    {
        IProduct product = FactoryMethod();
        product.Use();
    }
}

// This is a specific subclass that decides which toy to make
public class ConcreteCreator : Creator
{
    // This machine knows how to make the ConcreteProduct (a specific toy)
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}
