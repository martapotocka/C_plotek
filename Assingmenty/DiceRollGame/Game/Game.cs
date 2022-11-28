public class Game
{

    private const int NumberOfTries = 3;

    public void Run()
    {
        MessagePrinter.WelcomeUser(NumberOfTries);
        GameResult isWon = PlayGame();
        MessagePrinter.PrintGameResult(isWon);
    }
    private GameResult PlayGame()
    {
        int triesUsed = 0;
        Random random = new Random();
        var _diceRoller = new DiceRoller(random);
        int randomNumber = _diceRoller.Roll();

        while (triesUsed < NumberOfTries)
        {
            int validUserInput = UserInputProvider.Provide();

            if (validUserInput == randomNumber)
            {
                return GameResult.Victory;
            }

            MessagePrinter.PrintWrongNumber();
            triesUsed++;
        }
        return GameResult.Loss;
    }
}
