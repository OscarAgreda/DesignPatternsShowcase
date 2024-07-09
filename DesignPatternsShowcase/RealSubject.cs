namespace DesignPatternsShowcase;

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject Request");
    }
}