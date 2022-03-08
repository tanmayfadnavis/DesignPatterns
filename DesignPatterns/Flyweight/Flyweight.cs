public abstract class Flyweight
{
    public abstract void Operation(int extrinsicState);
}

public class ConcreteFlyweight: Flyweight
{
    public override void Operation(int extrinsicState)
    {
        Console.WriteLine($"Concrete flyweight: {extrinsicState}");
    }
}

public class UnsharedConcreteFlyweight: Flyweight
{
    public override void Operation(int extrinsicState)
    {
        Console.WriteLine($"Unshared concrete flyweight: {extrinsicState}");
    }
}

public class FlyweightFactory
{
    private Dictionary<int, Flyweight> flyweights { get; set; } = new Dictionary<int, Flyweight>();

    public FlyweightFactory()
    {
        flyweights.Add(1, new ConcreteFlyweight());
        flyweights.Add(2, new ConcreteFlyweight());
        flyweights.Add(3, new ConcreteFlyweight());
    }
    public Flyweight GetFlyweight(int key)
    {
        return flyweights[key];
    }
}

public class Client
{
    public static void Main()
    {
        int extrinsicState = 42;

        FlyweightFactory factory = new FlyweightFactory();

        factory.GetFlyweight(1).Operation(++extrinsicState);
        factory.GetFlyweight(2).Operation(++extrinsicState);

        UnsharedConcreteFlyweight unsharedConcrete = new UnsharedConcreteFlyweight();
        unsharedConcrete.Operation(++extrinsicState);
    }
}
