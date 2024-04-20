namespace Memento;

public class History
{
    private readonly List<EditorState> _states = [];

    public void Push(EditorState state)
    {
        _states.Add(state);
    }

    public EditorState Pop()
    {
        EditorState lastState = _states.Last();
        _states.Remove(lastState);

        return lastState;
    }
}
