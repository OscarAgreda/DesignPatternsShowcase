namespace DesignPatternsShowcase;

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request == 2)
        {
            Console.WriteLine("ConcreteHandler2 handled request");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}