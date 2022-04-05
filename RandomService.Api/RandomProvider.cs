namespace RandomService.Api
{
    public class RandomProvider
    {
        private static readonly Random instance = new();

        public int Get(int min, int max) => instance.Next(min, max);
    }
}
