namespace DesignPatternsShowcase;

public interface IState
{
    void Handle(ContextState context);
}