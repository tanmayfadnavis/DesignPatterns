public class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPart1();
        builder.BuildPart2();
        builder.BuildPart3();
    }
}

public abstract class Builder
{
    public abstract void BuildPart1();
    public abstract void BuildPart2();
    public abstract void BuildPart3();
    public abstract Product GetProduct();
}

public class ConcreteBuilder1 : Builder
{
    private Product product = new Product();

    public override void BuildPart1()
    {
        product.Add("Part1_Builder1");
    }

    public override void BuildPart2()
    {
        product.Add("Part2_Builder1");
    }

    public override void BuildPart3()
    {
        product.Add("Part3_Builder1");
    }

    public override Product GetProduct()
    {
        return product;
    }
}


public class ConcreteBuilder2 : Builder
{
    private Product product = new Product();

    public override void BuildPart1()
    {
        product.Add("Part1_Builder2");
    }

    public override void BuildPart2()
    {
        product.Add("Part2_Builder2");
    }

    public override void BuildPart3()
    {
        product.Add("Part3_Builder2");
    }

    public override Product GetProduct()
    {
        return product;
    }
}

public class Product
{
    private List<String> parts;

    public Product()
    {
        parts = new List<String>();
    }

    public void Add(string part)
    {
        parts.Add(part);
    }

    public void Display()
    {
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }
    }
}

public class Client
{
    public static void Main()
    {
        Director director = new ();
        Builder builder1 = new ConcreteBuilder1();
        Builder builder2 = new ConcreteBuilder2();

        director.Construct(builder1);
        Product product1 = builder1.GetProduct();
        product1.Display();

        director.Construct(builder2);
        Product product2 = builder2.GetProduct();
        product2.Display();
    }
}