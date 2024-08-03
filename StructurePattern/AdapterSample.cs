/*
The Adapter pattern is like a power plug adapter. Imagine you bought an electronic device in the United States,
but it has a different plug than the one used in Brazil. To use this device, you need an adapter that converts
the US plug to the Brazilian standard. Similarly, the Adapter pattern converts the interface of a class into
another interface that the client expects.
*/
namespace DesignPatternsSamples.StructurePattern;

// Interface expected by the client (Brazilian power outlet standard)
public interface ITarget
{
    void Request(); // Method that the client expects
}

// Existing class with a different interface (US plug)
public class Adaptee
{
    public void SpecificRequest() { /* Existing functionality */ }
}

// Adapter that does the conversion (power outlet adapter)
public class Adapter : ITarget
{
    // Instance of the class with the different interface
    private Adaptee adaptee = new(); 

    // Converts the call to the expected interface
    public void Request() 
        => adaptee.SpecificRequest();
}
