namespace DesignPatternsShowcase;

public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent Operation");
    }
}