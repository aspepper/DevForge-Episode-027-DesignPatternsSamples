namespace DesignPatternsSamples.ComportamentalPattern;

// Memento class that stores the state
public class Memento(string state)
{
    public string State { get; private set; } = state;
}

// Originator class that creates a Memento
public class Originator
{
    public string State { get; set; }

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
public class Caretaker
{
    private List<Memento> mementos = new();
    private Originator originator;

    public Caretaker(Originator originator)
    {
        this.originator = originator;
    }

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