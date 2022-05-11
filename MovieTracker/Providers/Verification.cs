using MovieTracker.Exceptions;

namespace MovieTracker.Providers
{
    public class Verification
    {
        public static void CheckTitleLength(string title)
        {
            if (title.Length < 1 || title.Length > 50)
            {
                throw new TitleLengthException("Title must be between 1 and 50 characters long.");
            }
        }
    }
}
