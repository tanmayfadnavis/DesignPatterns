public class Context
{
    private string name;
    public Context(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}

public abstract class Expression
{
    public abstract void Interpret(Context context);
}

public class ConcreteExpression1: Expression
{
    public override void Interpret(Context context)
    {
        if (context.Name.StartsWith("A"))
        {
            Console.WriteLine($"Interpreted by concrete expression 1");
        }
    }
}

public class ConcreteExpression2 : Expression
{
    public override void Interpret(Context context)
    {
        if (context.Name.StartsWith("Z"))
        {
            Console.WriteLine($"Interpreted by concrete expression 2");
        }
    }
}

public class Client
{
    public static void Main()
    {
        Context context = new Context("Zsbdfh");
        List<Expression> expressions = new List<Expression>();
        expressions.Add(new ConcreteExpression1());
        expressions.Add(new ConcreteExpression2());

        foreach(Expression expression in expressions)
        {
            expression.Interpret(context);
        }
    }
}
