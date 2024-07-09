namespace DesignPatternsShowcase;

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request == 1)
        {
            Console.WriteLine("ConcreteHandler1 handled request");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}