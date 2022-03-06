public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

public abstract class AbstractProductA
{
    public abstract void ShowA();
}

public abstract class AbstractProductB
{
    public abstract void ShowB();
}

public class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        Console.WriteLine("Factory 1 creating Product A1");
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        Console.WriteLine("Factory 1 creating Product B1");
        return new ProductB1();
    }
}

public class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}

public class ProductA1: AbstractProductA
{
    public override void ShowA()
    {
        Console.WriteLine("This is Product A1");
    }
}

public class ProductA2: AbstractProductA
{
    public override void ShowA()
    {
        Console.WriteLine("This is Product A2");
    }
}

public class ProductB1: AbstractProductB
{
    public override void ShowB()
    {
        Console.WriteLine("This is product B1");
    }
}

public class ProductB2 : AbstractProductB
{
    public override void ShowB()
    {
        Console.WriteLine("This is product B2");
    }
}

public class Client
{
    public static void Main()
    {
        // ConcreteFactory 1.
        AbstractFactory abstractFactory = new ConcreteFactory1();
        AbstractProductA productA = abstractFactory.CreateProductA();
        productA.ShowA();
        AbstractProductB productB = abstractFactory.CreateProductB();
        productB.ShowB();

        // ConcreteFactory 2.
        abstractFactory = new ConcreteFactory2();
        productA = abstractFactory.CreateProductA();
        productA.ShowA();
        productB = abstractFactory.CreateProductB();
        productB.ShowB();
    }
}