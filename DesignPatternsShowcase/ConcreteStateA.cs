namespace DesignPatternsShowcase;

public class ConcreteStateA : IState
{
    public void Handle(ContextState context)
    {
        Console.WriteLine("ConcreteStateA handles request.");
        context.State = new ConcreteStateB();
    }
}