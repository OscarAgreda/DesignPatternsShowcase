namespace DesignPatternsShowcase;

public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB Operation");
    }
}