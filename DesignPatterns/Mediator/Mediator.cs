public abstract class Colleague
{
    protected Mediator mediator;
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}

public class ConcreteColleague1: Colleague
{
    public ConcreteColleague1(Mediator mediator):base(mediator)
    {
    }

    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Concrete Colleague 1 received message: {message}");
    }
}

public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Concrete Colleague 2 received message: {message}");
    }
}

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}

public class ConcreteMediator: Mediator
{
    ConcreteColleague1 colleague1;
    ConcreteColleague2 colleague2;

    public ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }

    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            colleague2.Notify(message);
        }

        if (colleague == colleague2)
        {
            colleague1.Notify(message);
        }
    }
}

public class Client
{
    public static void Main()
    {
        ConcreteMediator mediator = new ConcreteMediator();
        ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
        ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

        mediator.Colleague1 = colleague1;
        mediator.Colleague2 = colleague2;

        colleague1.Send("Hey there");
        colleague2.Send("How are you?");
    }
}