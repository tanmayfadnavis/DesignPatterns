public abstract class Element
{
    public abstract void Accept(Visitor visitor);
}

public class ConcreteElementA: Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
}

public class ConcreteElementB : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
}

public abstract class Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA element);
    public abstract void VisitConcreteElementB(ConcreteElementB element);
}

public class Visitor1: Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteElementA visited by Visitor1");
    }

    public override void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteElementb visited by Visitor1");
    }
}

public class Visitor2 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteElementA visited by Visitor2");
    }

    public override void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteElementb visited by Visitor2");
    }
}

public class ObjectStructure
{
    List<Element> elements = new List<Element>();

    public void Attach(Element element)
    {
        elements.Add(element);
    }
    public void Detach(Element element)
    {
        elements.Remove(element);
    }

    public void Accept(Visitor visitor)
    {
        foreach (Element element in elements)
        {
            element.Accept(visitor);
        }
    }
}

public class Client
{
    public static void Main()
    {
        ObjectStructure objectStructure = new ObjectStructure();
        objectStructure.Attach(new ConcreteElementA());
        objectStructure.Attach(new ConcreteElementB());

        Visitor1 v1 = new Visitor1();
        Visitor2 v2 = new Visitor2();

        objectStructure.Accept(v1);
        objectStructure.Accept(v2);
    }
}