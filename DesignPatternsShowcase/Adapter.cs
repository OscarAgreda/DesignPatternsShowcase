namespace DesignPatternsShowcase;

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee = new Adaptee();

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}