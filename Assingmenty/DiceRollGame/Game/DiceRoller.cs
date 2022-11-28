public class DiceRoller
{
    private readonly Random _random;
    private const int DiceSides = 6;
    public DiceRoller(Random random)
    {
        _random = random;
    }
    public int Roll()
    {
        return _random.Next(1, DiceSides + 1);
    }
}