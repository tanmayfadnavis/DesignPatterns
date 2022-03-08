public abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 1 && request <= 100)
        {
            Console.WriteLine($"Handler1 handled request number {request}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 101 && request <= 200)
        {
            Console.WriteLine($"Handler2 handled request number {request}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}

public class Client
{
    public static void Main()
    {
        ConcreteHandler1 concreteHandler1 = new ConcreteHandler1();
        ConcreteHandler2 concreteHandler2 = new ConcreteHandler2();

        concreteHandler1.SetSuccessor(concreteHandler2);

        List<int> requests = new List<int> { 1, 2, 3, 42, 159, 70 };
        foreach (int request in requests)
        {
            concreteHandler1.HandleRequest(request);
        }
    }
}