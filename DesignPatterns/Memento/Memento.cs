public class Memento
{
    string state;

    public Memento(string state)
    {
        this.state = state;
    }

    public string State
    {
        get { return state; }
    }
}

public class CareTaker
{
    Memento memento;

    public Memento Memento
    {
        get { return memento; }
        set { memento = value; }
    }
}

public class Originator
{
    private string state;

    public string State
    {
        get { return state; }
        set { 
            state = value;
            Console.WriteLine($"State = {state}");
        }
    }

    public Memento CreateMemento()
    {
        return new Memento(state);
    }

    public void SetMemento(Memento memento)
    {
        Console.WriteLine($"Restoring state...");
        State = memento.State;
    }
}

public class Client
{
    public static void Main()
    {
        Originator originator = new Originator();
        originator.State = "State 1";

        CareTaker careTaker = new CareTaker();
        careTaker.Memento = originator.CreateMemento();

        originator.State = "State 2";

        originator.SetMemento(careTaker.Memento);
    }
}

