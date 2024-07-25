/*
The Factory Method is a way to create objects in programming. Imagine you're in a toy factory. Instead of making each toy yourself,
you have various machines (subclasses) specialized in making specific types of toys. You just need to press the right button on the
right machine to get the toy you want.

In code, the Factory Method is like the button you press on the machine to create the toy. It defines a way to create an object but
leaves it to the subclasses (machines) to decide exactly which object to create.

Given your background in software development and your experience with large projects, implementing the Factory Method can significantly
enhance the modularity and flexibility of your code, making it easier to manage and extend, similar to how you structured solutions
for major companies in the past.
*/
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
