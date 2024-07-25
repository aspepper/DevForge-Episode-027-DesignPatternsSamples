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
    private string word = word;

    public void Interpret(ContextInterpret context)
    {
        if (context.Input.Contains(word))
        {
            context.Output += $" {word}";
        }
    }
}
