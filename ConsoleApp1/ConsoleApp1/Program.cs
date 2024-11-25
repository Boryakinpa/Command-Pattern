using ConsoleApp1;

internal class Program
{
    private static void Main()
    {
        Invoker invoker = new Invoker();
        TextEditor receiver = new TextEditor();
        ConcreteCommand command = new ConcreteCommand(receiver);
        invoker.SetCommand(command);
        invoker.Insert("word");
        invoker.Delete(2);
        invoker.Print();
        invoker.Cancel();
        invoker.Print();
    }
}
