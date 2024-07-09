namespace DesignPatternsShowcase;

public class Proxy : ISubject
{
    private readonly RealSubject _realSubject = new RealSubject();

    public void Request()
    {
        Console.WriteLine("Proxy Request");
        _realSubject.Request();
    }
}