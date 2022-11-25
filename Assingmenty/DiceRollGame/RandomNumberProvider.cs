internal class RandomNumberProvider
{
    public static int Generate()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }
}