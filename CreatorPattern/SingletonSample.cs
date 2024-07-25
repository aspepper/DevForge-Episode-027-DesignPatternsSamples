/* The Singleton is used to ensure that a class has only one instance and provides a global point of access to it. */
namespace DesignPatternsSamples;

public class Singleton
{
    // Private static variable to hold the single instance of the Singleton class
    private static Singleton? instance;

    // Public static property to get the single instance of the Singleton class
    // Use the null-coalescing assignment operator to assign a new instance if the instance is null
    public static Singleton Instance => instance ??= new Singleton();

    // Private constructor to prevent instantiation from outside the class
    private Singleton()
    { }
}
