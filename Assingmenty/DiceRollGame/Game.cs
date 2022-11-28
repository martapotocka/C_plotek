class Game
{

    private readonly int _numberOfTries = 3;

    public void Run()
    {
        MessagePrinter.WelcomeUser(_numberOfTries);
        bool isWon = PlayGame();
        MessagePrinter.PrintGameResult(isWon);
    }
    private bool PlayGame()
    {
        int counter = 0;
        int randomNumber = RandomNumberProvider.Generate();

        while (counter < _numberOfTries)
        {
            int validUserInput = UserInputProvider.Provide();

            if (validUserInput == randomNumber)
            {
                return true;
            }

            MessagePrinter.PrintWrongNumber();
            counter++;
        }
        return false;
    }
}