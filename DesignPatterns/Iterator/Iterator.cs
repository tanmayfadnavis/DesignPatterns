public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}

public class ConcreteAggregate : Aggregate
{
    List<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return items.Count; }
    }

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

public abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
}

public class ConcreteIterator: Iterator
{
    ConcreteAggregate aggregate;
    int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override object Next()
    {
        object ret = null;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }
        return ret;
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}

public class Client
{
    public static void Main()
    {
        ConcreteAggregate concrete = new ConcreteAggregate();
        concrete[0] = "Zero";
        concrete[1] = "One";
        concrete[2] = "Two";

        Iterator iterator = concrete.CreateIterator();

        object item = iterator.First();
        while(item != null)
        {
            Console.WriteLine(item);
            item = iterator.Next();
        }
    }
}
