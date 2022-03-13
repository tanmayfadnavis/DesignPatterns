public abstract class Subject
{
    private List<Observer> observers = new List<Observer>();

    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (Observer observer in observers)
        {
            observer.Update();
        }
    }
}

public class ConcreteSubject : Subject
{
    private string state;

    public string State
    {
        get { return state; }
        set { state = value; }
    }
}

public abstract class Observer
{
    public abstract void Update();
}

public class ConcreteObserver: Observer
{
    private string name;
    private string state;
    private ConcreteSubject subject;

    public ConcreteObserver(string name, ConcreteSubject subject)
    {
        this.name = name;
        this.subject = subject;
    }

    public ConcreteSubject Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public override void Update()
    {
        state = subject.State;
        Console.WriteLine($"Observe {name} new state is {state}");
    }
}

public class Client
{
    public static void Main()
    {
        ConcreteSubject subject = new ConcreteSubject();

        subject.Attach(new ConcreteObserver("A", subject));
        subject.Attach(new ConcreteObserver("B", subject));
        subject.Attach(new ConcreteObserver("C", subject));

        subject.State = "this is new state";
        subject.Notify();
    }
}
