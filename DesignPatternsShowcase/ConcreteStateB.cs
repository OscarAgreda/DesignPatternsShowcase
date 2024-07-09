namespace DesignPatternsShowcase;

public class ConcreteStateB : IState
{
    public void Handle(ContextState context)
    {
        Console.WriteLine("ConcreteStateB handles request.");
        context.State = new ConcreteStateA();
    }
}