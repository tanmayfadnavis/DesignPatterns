public abstract class Strategy
{
    public abstract void AlgorithmicInterface();
}

public class StrategyA: Strategy
{
    public override void AlgorithmicInterface()
    {
        Console.WriteLine("Strategy A Implementation");
    }
}

public class StrategyB : Strategy
{
    public override void AlgorithmicInterface()
    {
        Console.WriteLine("Strategy B Implementation");
    }
}

public class StrategyC : Strategy
{
    public override void AlgorithmicInterface()
    {
        Console.WriteLine("Strategy C Implementation");
    }
}

public class Context
{
    private Strategy strategy;

    public Context(Strategy strategy)
    {
        this.strategy = strategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmicInterface();
    }
}

public class Client
{
    public static void Main()
    {
        Context context = new Context(new StrategyA());
        context.ContextInterface();

        context=new Context(new StrategyB());
        context.ContextInterface();

    }
}