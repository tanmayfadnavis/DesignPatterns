public class Subsystem1
{
    public void One()
    {
        Console.WriteLine("Subsystem1");
    }
}

public class Subsystem2
{
    public void Two()
    {
        Console.WriteLine("Subsystem2");
    }
}

public class Subsystem3
{
    public void Three()
    {
        Console.WriteLine("Subsystem3");
    }
}

public class Facade
{
    Subsystem1 subsystem1 = new Subsystem1();
    Subsystem2 subsystem2 = new Subsystem2();
    Subsystem3 subsystem3 = new Subsystem3();

    public void PerformA()
    {
        subsystem1.One();
        subsystem2.Two();
    }

    public void PerformB()
    {
        subsystem3.Three();
    }
}

public class Client
{
    public static void Main()
    {
        Facade facade = new Facade();
        facade.PerformA();
        facade.PerformB();
    }
}