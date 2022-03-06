public abstract class Prototype
{
    string name;

    public Prototype(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }

    public abstract Prototype Clone();
}

public class ConcretePrototype1: Prototype
{
    public ConcretePrototype1(string name): base(name)
    {

    }

    //Creates a shallow copy.
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

public class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(string name) : base(name)
    {

    }

    //Creates a shallow copy.
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

public class Client
{
    public static void Main()
    {
        ConcretePrototype1 p1 = new ConcretePrototype1("Prototyp_one");
        ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        Console.WriteLine($"Cloned name is {c1.Name}");

    }
}