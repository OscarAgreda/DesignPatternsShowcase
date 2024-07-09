namespace DesignPatternsShowcase;

public class ConcreteObserverB : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserverB has been notified");
    }
}