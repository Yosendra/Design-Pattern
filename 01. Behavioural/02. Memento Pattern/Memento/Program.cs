using Memento;

var editor = new Editor();
var history = new History();

editor.Content = "a";
Console.WriteLine($"Current state: {editor.Content}");  // "a"

history.Push(editor.CreateState());
editor.Content = "b";
Console.WriteLine($"Current state: {editor.Content}");  // "b"

history.Push(editor.CreateState());
editor.Content = "c";
Console.WriteLine($"Current state: {editor.Content}");  // "c"


editor.Restore(history.Pop());                                // Undo
Console.WriteLine($"Undo, current state: {editor.Content}");  // "b"

editor.Restore(history.Pop());                                // Undo
Console.WriteLine($"Undo, current state: {editor.Content}");  // "a"

Console.ReadKey();