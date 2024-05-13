using System;


abstract class ChristmasTree
{
    public abstract void Decorate();
}


class SimpleChristmasTree : ChristmasTree
{
    public override void Decorate()
    {
        Console.WriteLine("Simple Christmas Tree");
    }
}


abstract class Decorator : ChristmasTree
{
    protected ChristmasTree christmasTree;

    public Decorator(ChristmasTree christmasTree)
    {
        this.christmasTree = christmasTree;
    }

    public override void Decorate()
    {
        christmasTree.Decorate();
    }
}


class BallsDecorator : Decorator
{
    public BallsDecorator(ChristmasTree christmasTree) : base(christmasTree)
    {
    }

    public override void Decorate()
    {
        base.Decorate();
        Console.WriteLine("Add Balls");
    }
}


class GarlandDecorator : Decorator
{
    public GarlandDecorator(ChristmasTree christmasTree) : base(christmasTree)
    {
    }

    public override void Decorate()
    {
        base.Decorate();
        Console.WriteLine("Add Garland");
    }
}


class LEDLightsDecorator : Decorator
{
    public LEDLightsDecorator(ChristmasTree christmasTree) : base(christmasTree)
    {
    }

    public override void Decorate()
    {
        base.Decorate();
        Console.WriteLine("Add LED Lights");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ChristmasTree tree = new SimpleChristmasTree();

        
        tree = new BallsDecorator(tree);
        tree = new GarlandDecorator(tree);
        tree = new LEDLightsDecorator(tree);

        
        tree.Decorate();
    }
}