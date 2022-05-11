namespace MovieTracker.Exceptions
{
    public class TitleLengthException : ApplicationException
    {
        public TitleLengthException() {}
        public TitleLengthException(string message) : base(message) {}
    }
}
