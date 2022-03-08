public abstract class Subject
{
    public abstract void Request();
}

public class RealSubject: Subject
{
    public override void Request()
    {
        Console.WriteLine("Real subject request method");
    }
}

public class Proxy : Subject
{
    private RealSubject subject;

    public override void Request()
    {
        if (subject == null)
        {
            subject = new RealSubject();
        }

        subject.Request();
    }
}

public class Client
{
    public static void Main()
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}