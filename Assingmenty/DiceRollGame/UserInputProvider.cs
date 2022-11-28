
class UserInputProvider
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
        while (!Validate(userInput, out validUserInput));

        return validUserInput;
    }
    public static bool Validate(string userInput, out int validUserInput)
    {
        //if (userInput == "")
        //{
        //    validUserInput = 0;
        //    return false;
        //}
        if (!int.TryParse(userInput, out validUserInput))
        {
            return false;
        }
        if (validUserInput < 1 || validUserInput > 6)
        {
            return false;
        }
        return true;
    }
}



