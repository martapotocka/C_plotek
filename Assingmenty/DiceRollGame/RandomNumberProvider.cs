internal class RandomNumberProvider
{
    public static int Generate()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }
}