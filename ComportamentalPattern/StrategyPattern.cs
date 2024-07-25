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
    private IStrategy strategy = strategy;

    public void ContextInterface()
    {
        strategy.AlgorithmInterface(); // Execute the strategy
    }
}