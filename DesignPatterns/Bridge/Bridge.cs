public abstract class Abstraction
{
    protected Implementor implementor;

    public Implementor Implementor
    {
        set { implementor = value; }
    }

    public virtual void Operation()
    {
        implementor.Operation();
    }
}

public abstract class Implementor
{
    public abstract void Operation();
}

public class ConcreteImplementorA: Implementor
{
    public override void Operation()
    {
        Console.WriteLine("Concrete Implementor A operation");
    }
}

public class ConcreteImplementorB : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("Concrete Implementor B operation");
    }
}

public class RefinedAbstraction: Abstraction
{
    public override void Operation()
    {
        implementor.Operation();
    }
}

public class Client
{
    public static void Main()
    {
        Abstraction abstraction = new RefinedAbstraction();
        abstraction.Implementor = new ConcreteImplementorA();
        abstraction.Operation();

        abstraction.Implementor = new ConcreteImplementorB();
        abstraction.Operation();
    }
}
