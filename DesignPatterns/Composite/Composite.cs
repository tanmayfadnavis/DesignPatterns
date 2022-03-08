public abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
}

public class Leaf: Component
{
    public Leaf(string name) : base(name)
    {
    }
    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }
    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}

public class Composite : Component
{
    List<Component> children = new List<Component>();
    public Composite(string name)
        : base(name)
    {
    }
    public override void Add(Component component)
    {
        children.Add(component);
    }
    public override void Remove(Component component)
    {
        children.Remove(component);
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
        foreach (Component component in children)
        {
            component.Display(depth + 2);
        }
    }
}

public class Client
{
    public static void Main()
    {
        Composite root = new Composite("root");
        root.Add(new Leaf("A"));
        root.Add(new Leaf("B"));
        root.Display(1);
    }
}

