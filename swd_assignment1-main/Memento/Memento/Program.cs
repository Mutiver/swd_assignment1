
using Memento_namespace;

string input;

Caretaker caretaker = new Caretaker();
Originator originator = new Originator("initial state");
originator.SaveState(caretaker);
Console.WriteLine("click r to redo \nclick u to undo \n");


while (true)
{
    
    input = Console.ReadLine();
    if (input == "r" || input == "u")
    {
        Console.Clear();
        switch (input)
        {
            case "u":
                Console.WriteLine("undo clicked \n");
                originator.Undo(caretaker);
                break;
            case "r":
                Console.WriteLine("redo clicked \n");
                originator.Redo(caretaker);
                break;
            default:
                break;
        }
    }
    else
    {
        Console.Clear();
        originator.ChangeState(input);
        originator.SaveState(caretaker);
    }

}
