namespace RandomService.Api
{
    public class RandomProvider
    {
        private static readonly Random instance = new();

        public int Get(int min, int max) => instance.Next(min, max);

        public DateTime Get() => new DateTime().Add(new TimeSpan(Get(1, 1000), Get(10, 999), Get(10, 4544)));
    }
}
