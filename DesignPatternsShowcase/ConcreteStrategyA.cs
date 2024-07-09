namespace DesignPatternsShowcase;

public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy A");
    }
}