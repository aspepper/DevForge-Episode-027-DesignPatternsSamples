/*
The Strategy pattern defines a family of algorithms, encapsulates
each one, and makes them interchangeable. Imagine you are playing
a racing game and can choose different strategies to win, such as
driving fast, driving defensively, or avoiding obstacles.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Strategy interface that defines the algorithm interface
public interface IStrategy
{
    void AlgorithmInterface(); // Method for the strategy algorithm
}

// Concrete strategy that implements a specific algorithm
public class ConcreteStrategyA : IStrategy
{
    public void AlgorithmInterface()
    {
        // Implementation of a specific algorithm
    }
}

// Context class that uses a strategy
public class ContextStrategy(IStrategy strategy)
{
    private readonly IStrategy strategy = strategy;

    public void ContextInterface()
    {
        strategy.AlgorithmInterface(); // Execute the strategy
    }
}