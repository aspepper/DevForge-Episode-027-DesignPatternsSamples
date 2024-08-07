/*
The Interpreter pattern is used to evaluate or interpret
languages. Think of it as a translator who converts
sentences from one language to another, following specific
grammatical rules. It’s like when you use a dictionary to
understand words in a foreign language.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Context class to hold the input string
public class ContextInterpret
{
    public string? Input { get; set; }
    public string? Output { get; set; }
}

// Expression interface that defines the Interpret method
public interface IExpression
{
    void Interpret(ContextInterpret context);
}

// TerminalExpression class for specific words
public class TerminalExpression(string word) : IExpression
{
    private readonly string word = word;

    public void Interpret(ContextInterpret context)
    {
        if(context == null || context.Input == null) return;
        if (context.Input.Contains(word))
        {
            context.Output += $" {word}";
        }
    }
}
