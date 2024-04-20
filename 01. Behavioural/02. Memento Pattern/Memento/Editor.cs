namespace Memento;

public class Editor
{
    public string Content { get; set; } = string.Empty;

    public EditorState CreateState()
    {
        return new(Content);
    }

    public void Restore(EditorState state)
    {
        Content = state.Content;
    }
}
