static class UserInputProvider
{
    public static int Provide()
    {
        string userInput;
        int validUserInput;
        do
        {
            MessagePrinter.AskForUserInput();
            userInput = Console.ReadLine();
        }
        while (!int.TryParse(userInput, out validUserInput));

        return validUserInput;
    }
}


