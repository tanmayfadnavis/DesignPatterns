public class Singleton
{
    static Singleton singleton;

    protected Singleton()
    {
    }

    public static Singleton Instance()
    {
        if (singleton == null)
        {
            singleton = new Singleton();
        }

        return singleton;
    }
}

public class Client
{
    public static void Main()
    {
        Singleton singleton1 = Singleton.Instance();
        Singleton singleton2 = Singleton.Instance();

        if (singleton1 == singleton2)
        {
            Console.WriteLine("Same instance!!");
        }
    }
}
