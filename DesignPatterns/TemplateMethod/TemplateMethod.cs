public abstract class Template
{
    public abstract void PrimitiveMethod1();
    public abstract void PrimitiveMethod2();

    public void TemplateMethod()
    {
        PrimitiveMethod1();
        PrimitiveMethod2();
    }
}

public class ConcreteClassA: Template
{
    public override void PrimitiveMethod1()
    {
        Console.WriteLine("A's PrimitiveMethod1");
    }

    public override void PrimitiveMethod2()
    {
        Console.WriteLine("A's PrimitiveMethod2");
    }
}

public class ConcreteClassB : Template
{
    public override void PrimitiveMethod1()
    {
        Console.WriteLine("B's PrimitiveMethod1");
    }

    public override void PrimitiveMethod2()
    {
        Console.WriteLine("B's PrimitiveMethod2");
    }
}

public class Client
{
    public static void Main()
    {
        Template template = new ConcreteClassA();
        template.TemplateMethod();
    }
}