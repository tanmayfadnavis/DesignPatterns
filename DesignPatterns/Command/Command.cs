﻿public abstract class Command
{
    protected Receiver receiver;

    protected Command(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();

}

public class ConcreteCommand: Command
{
    public ConcreteCommand(Receiver receiver): base(receiver)
    {
    }

    public override void Execute()
    {
        receiver.Action();
    }
}

public class Receiver
{
    public void Action()
    {
        Console.WriteLine("Receiver's action method");
    }
}

public class Invoker
{
    Command command;

    public void SetCommand(Command command)
    {
        this.command = command;
    }

    public void ExecuteCommand()
    {
        command.Execute();
    }
}

public class Client
{
    public static void Main()
    {
        Receiver receiver = new Receiver();
        Command command = new ConcreteCommand(receiver);

        Invoker invoker = new Invoker();
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
    }
}
