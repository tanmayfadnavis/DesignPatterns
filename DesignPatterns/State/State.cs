public abstract class State
{
    public abstract void Handle(Context context);
}

public class ConcreteStateA: State
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateB();
    }
}

public class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateA();
    }
}

public class Context
{
    State state;

    public Context(State state)
    {
        this.state = state;
    }

    public State State
    {
        get { return state; }
        set 
        { 
            state = value;
            Console.WriteLine($"State: {state.GetType().Name}");
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}

public class Client
{
    public static void Main()
    {
        Context context = new Context(new ConcreteStateA());
        context.Request();
        context.Request();
        context.Request();
    }
}