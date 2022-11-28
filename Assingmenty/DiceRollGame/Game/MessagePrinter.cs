class MessagePrinter
{
    public static void WelcomeUser(int numberOfTries)
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {numberOfTries} tries.");
    }

    public static void AskForUserInput()
    {
        Console.WriteLine("Enter a number: ");
    }

    public static void PrintGameResult(GameResult isWon)
    {
        var message = isWon == GameResult.Victory ? "You win." : "You lose.";
        Console.WriteLine(message);
    }

    internal static void PrintWrongNumber()
    {
        Console.WriteLine("Wrong number");
    }
}