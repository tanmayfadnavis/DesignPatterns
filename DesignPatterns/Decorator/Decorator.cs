public abstract class Component
{
    public abstract void Operation();
}

public class ConcreteComponent: Component
{
    public override void Operation()
    {
        Console.WriteLine("Concrete Component Operation");
    }
}

public abstract class Decorator : Component
{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        component.Operation();
    }
}

public class ConcreteDecorator1: Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecorator 1 operation complete");
    }
}

public class ConcreteDecorator2: Decorator
{
    public override void Operation()
    {
        base.Operation();
        AdditionalOperation();
        Console.WriteLine("Concretedecorator 2 operation complete");
    }

    private void AdditionalOperation()
    {
        Console.WriteLine("Additional operation");
    }
}

public class Client
{
    public static void Main()
    {
        ConcreteComponent component = new ConcreteComponent();
        ConcreteDecorator1 decorator1 = new ConcreteDecorator1();
        ConcreteDecorator2 decorator2 = new ConcreteDecorator2();

        decorator1.SetComponent(component);
        decorator2.SetComponent(decorator1);
        decorator2.Operation();
    }
}