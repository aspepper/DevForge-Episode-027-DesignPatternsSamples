/*
The Builder pattern is used to construct complex objects step by step. Imagine you are assembling a sandwich
at a deli. First, you choose the bread, then the meat, the vegetables, the cheese, and the sauces. You can
assemble different types of sandwiches using the same process, just by changing the ingredients. The Builder
separates the construction (assembling the sandwich) from the representation (the specific type of sandwich).
*/
namespace DesignPatternsSamples.CreatorPattern;

// Product (the sandwich) with many parts
public class Product
{
    // Complex object with many parts.
}

// Builder Interface (the plan to build the sandwich)
public interface IBuilder
{
    // Method to add a part (e.g., bread)
    void BuildPartA();

    // Method to add another part (e.g., meat) 
    void BuildPartB();

    // Method to get the finished sandwich
    Product GetResult(); 
}

// Concrete Builder (knows how to build the sandwich)
public class ConcreteBuilder : IBuilder
{
    private Product product = new Product();

    public void BuildPartA() 
    { /* Adds the bread */ }
    
    public void BuildPartB() 
    { /* Adds the meat */ }

    // Returns the finished sandwich
    public Product GetResult() => product; 
}
