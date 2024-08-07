/*
The Iterator pattern provides a way to sequentially access
the elements of an aggregate object without exposing its
underlying representation. Imagine you are listening to a
music playlist and can skip forward or backward to the next
song without knowing exactly how the list is stored.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Iterator interface
public interface IIterator
{
    bool HasNext();
    object Next();
}

// Concrete iterator class
public class ConcreteIterator(List<object> collection) : IIterator
{
    private List<object> collection = collection;
    private int position = 0;

    public bool HasNext()
    {
        return position < collection.Count;
    }

    public object Next()
    {
        if (!HasNext()) return null;
        return collection[position++];
    }
}

// Aggregate interface
public interface IAggregate
{
    IIterator CreateIterator();
}

// Concrete aggregate class
public class ConcreteAggregate : IAggregate
{
    private List<object> items = [];

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(items);
    }

    public void AddItem(object item)
    {
        items.Add(item);
    }
}