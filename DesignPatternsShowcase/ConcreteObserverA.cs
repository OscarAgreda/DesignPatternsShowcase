namespace DesignPatternsShowcase;

public class ConcreteObserverA : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserverA has been notified");
    }
}