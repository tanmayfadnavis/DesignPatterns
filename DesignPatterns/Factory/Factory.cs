using System.Net.Http.Headers;

public abstract class Creator
{
    public abstract Product FactoryMethod();
}

public class ConcreteCreator1 : Creator
{
    public override Product FactoryMethod()
    {
        return new ProductA();
    }
}

public class ConcreteCreaor2 : Creator
{
    public override Product FactoryMethod()
    {
        return new ProductB();
    }
}

public abstract class Product
{
    public abstract void Show();
}

public class ProductA: Product

{
    public override void Show()
    {
        Console.WriteLine("Product A created");
    }
}

public class ProductB: Product
{
    public override void Show()
    {
        Console.WriteLine("Product B created");
    }
}

public class Client
{
    public static void Main()
    {
        Creator creator = new ConcreteCreator1();
        Product product = creator.FactoryMethod();
        product.Show();
    }
}