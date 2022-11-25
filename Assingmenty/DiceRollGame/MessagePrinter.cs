class MessagePrinter
{
    public static void WelcomeUser(int numberOfTries)
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {numberOfTries.ToString()} tries.");
    }

    public static void AskForUserInput()
    {
        Console.WriteLine("Enter a number: ");
    }

    public static void PrintGameResult(bool isWon)
    {
        if (isWon) { Console.WriteLine("You win."); }
        else { Console.WriteLine("You lose."); }
    }

    internal static void PrintWrongNumber()
    {
        Console.WriteLine("Wrong number");
    }
}