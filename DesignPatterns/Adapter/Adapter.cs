public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("Target class Request()");
    }
}

public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("SpecificRequest() called");
    }
}

public class Adaptor: Target
{
    private Adaptee adaptee = new Adaptee();
    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}

public class Client
{
    public static void Main()
    {
        Target target = new Adaptor();
        target.Request();
    }
}
