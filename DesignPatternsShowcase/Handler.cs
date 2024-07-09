namespace DesignPatternsShowcase;

public abstract class Handler
{
    protected Handler _nextHandler;

    public void SetNext(Handler handler)
    {
        _nextHandler = handler;
    }

    public abstract void HandleRequest(int request);
}