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
    private Adaptee adaptee = new(); // Instance of the class with the different interface

    public void Request() => adaptee.SpecificRequest(); // Converts the call to the expected interface
}
