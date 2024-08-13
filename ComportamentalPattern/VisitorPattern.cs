/*
The Visitor pattern allows you to define a new operation
without changing the classes of the elements on which it
operates. Think of it as a tour guide who can explain
different parts of a museum without altering the museum
exhibits.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Visitor interface
public interface IVisitor
{
    void Visit(ElementA element);
    void Visit(ElementB element);
}

// Concrete visitor class
public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("Visiting ElementA");
    }
    public void Visit(ElementB element)
    {
        Console.WriteLine("Visiting ElementB");
    }
}

// Element interface
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete element class
public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}