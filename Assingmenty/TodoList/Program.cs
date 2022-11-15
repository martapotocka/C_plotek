using System;

Console.WriteLine("Hello!");

bool isExitSelected = false;
List<string> todos = new List<string>();

do
{
    AskForInput();
    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            isExitSelected = true;
            break;
        default:
            Console.WriteLine("Invalid input!");
            continue;
    }
}
while (!isExitSelected);


Console.WriteLine("Bye! Press any key to close the application.");
Console.ReadLine();

void AskForInput()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    string userInput;
    int index;

    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeAllTodos();
        userInput = Console.ReadLine();
    }
    while (!IsIndexValid(userInput, out index));

    RemoveTodoAtGivenIndex(index);
}

void RemoveTodoAtGivenIndex(int index)
{
    int idxOfItemToRemove = index - 1;
    string removedItem = todos[idxOfItemToRemove];
    todos.RemoveAt(idxOfItemToRemove);
    Console.WriteLine($"TODO removed: {removedItem}");
}

bool IsIndexValid(string selectedIndex, out int index)
{
    if (selectedIndex == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    if (!int.TryParse(selectedIndex, out index))
    {
        Console.WriteLine("The given index is not valid.");
        return false;
    }
    if (index > todos.Count || index <= 0)
    {
        Console.WriteLine("The given index is not valid.");
        return false;
    }
    return true;

}

void AddTodo()
{
    bool isInputValid = false;
    string userInput;
    do
    {
        Console.WriteLine("Enter a TODO description:");
        userInput = Console.ReadLine();
    }
    while (!IsTodoDescriptionValid(userInput));

    todos.Add(userInput);
    Console.WriteLine($"TODO successfully added: {userInput}");
}

bool IsTodoDescriptionValid(string userInput)
{
    if (userInput == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if (todos.Contains(userInput))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }


}
