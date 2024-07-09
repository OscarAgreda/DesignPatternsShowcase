namespace DesignPatternsShowcase;

public class Facade
{
    private readonly SubsystemA _subsystemA = new SubsystemA();
    private readonly SubsystemB _subsystemB = new SubsystemB();

    public void Operation()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}