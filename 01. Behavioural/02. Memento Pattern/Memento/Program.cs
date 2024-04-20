using Memento;

var editor = new Editor();
var history = new History();

editor.Content = "a";
history.Push(editor.CreateState());

editor.Content = "b";
history.Push(editor.CreateState());

editor.Content = "c";

// Current state is 'c' now
Console.WriteLine("Current state: "+ editor.Content);   // c

// Undo
editor.Restore(history.Pop());
Console.WriteLine("Undo state #1: " + editor.Content);  // b

// Undo again
editor.Restore(history.Pop());
Console.WriteLine("Undo state #2: " + editor.Content);  // a
Console.ReadKey();