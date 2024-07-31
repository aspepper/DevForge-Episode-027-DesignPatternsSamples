/* 
The Flyweight pattern minimizes memory usage by sharing as much 
data as possible among similar objects. It is useful in situations 
where many similar objects are needed.
 */
namespace DesignPatternsSamples.StructurePattern;

// Flyweight interface for the chess piece
public interface IChessPiece
{
    void Move(int x, int y);
}

// Concrete implementation of the chess piece
public class ChessPiece(string pieceType) : IChessPiece
{
    private readonly string pieceType = pieceType;

    public void Move(int x, int y)
    {
        Console.WriteLine($"{pieceType} moved to {x}, {y}");
    }
}

// Flyweight Factory that creates and manages chess piece objects
public class ChessPieceFactory
{
    private readonly Dictionary<string, IChessPiece> pieces = [];

    public IChessPiece GetChessPiece(string pieceType)
    {
        if (!pieces.TryGetValue(pieceType, out IChessPiece? value))
        {
            value = new ChessPiece(pieceType);
            pieces[pieceType] = value;
        }
        return value;
    }
}