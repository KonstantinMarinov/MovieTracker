namespace MovieTracker.Providers
{
    public static class GuidGenerator
    {
        public static Guid Generate()
        {
            return Guid.NewGuid();
        }
    }
}
