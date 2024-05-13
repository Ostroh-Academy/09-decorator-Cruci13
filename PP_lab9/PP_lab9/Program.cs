using System;


abstract class Component
{
    public abstract void Operation();
}


class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}


abstract class Decorator : Component
{
    protected Component component;

    public Decorator(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
        {
            component.Operation();
        }
    }
}


class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}


class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
        Console.WriteLine("ConcreteDecoratorB.AddedBehavior()");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Component component = new ConcreteComponent();

        
        Decorator decoratorA = new ConcreteDecoratorA(component);
        Decorator decoratorB = new ConcreteDecoratorB(decoratorA);

        
        decoratorB.Operation();
    }
}
