/*
The Memento pattern captures and restores an object's
internal state without violating its encapsulation.
Think of it as the 'undo' button in a text editor, which
allows you to return to a previous state of the document.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Memento class that stores the state
public class Memento(string state)
{
    public string State { get; private set; } = state;
}

// Originator class that creates a Memento
public class Originator
{
    public string State { get; set; } = string.Empty;

    public Memento SaveState()
    {
        return new Memento(State);
    }

    public void RestoreState(Memento memento)
    {
        State = memento.State;
    }
}

// Caretaker class that manages Mementos
public class Caretaker(Originator originator)
{
    private readonly List<Memento> mementos = [];
    private readonly Originator originator = originator;

    public void Save()
    {
        mementos.Add(originator.SaveState());
    }

    public void Undo()
    {
        if (mementos.Count > 0)
        {
            var memento = mementos.Last();
            originator.RestoreState(memento);
            mementos.Remove(memento);
        }
    }
}