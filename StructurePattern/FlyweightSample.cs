namespace DesignPatternsSamples.StructurePattern;

// Flyweight interface for the chess piece
public interface IChessPiece
{
    void Move(int x, int y);
}

// Concrete implementation of the chess piece
public class ChessPiece : IChessPiece
{
    private string pieceType;

    public ChessPiece(string pieceType)
    {
        this.pieceType = pieceType;
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"{pieceType} moved to {x}, {y}");
    }
}

// Flyweight Factory that creates and manages chess piece objects
public class ChessPieceFactory
{
    private Dictionary<string, IChessPiece> pieces = new Dictionary<string, IChessPiece>();

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
