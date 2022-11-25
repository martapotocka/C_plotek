class GameManager
{
    private readonly int _randomNumber = RandomNumberProvider.Generate();
    private readonly int _numberOfTries = 3;

    public void RunGame()
    {
        bool isWon;
        MessagePrinter.WelcomeUser(_numberOfTries);
        isWon = RunGame();
        MessagePrinter.PrintGameResult(isWon);
    }
    private bool RunGame()
    {
        int counter = 0;

        while (counter < _numberOfTries)
        {
            int validUserInput = UserInputProvider.Provide();

            if (validUserInput == _randomNumber)
            {
                Console.WriteLine("You win!");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong number");
                counter++;
                continue;
            }
        }
        return false;
    }
}