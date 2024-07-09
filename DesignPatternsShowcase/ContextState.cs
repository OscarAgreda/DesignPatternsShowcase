namespace DesignPatternsShowcase;

public class ContextState
{
    private IState _state;

    public ContextState(IState state)
    {
        State = state;
    }

    public IState State
    {
        get => _state;
        set
        {
            _state = value;
            Console.WriteLine($"State: {_state.GetType().Name}");
        }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}