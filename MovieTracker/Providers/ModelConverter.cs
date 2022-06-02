using MovieTracker.DtoModels;
using MovieTracker.Models;

namespace MovieTracker.Providers
{
    public static class ModelConverter
    {
        public static Movie ToModel(MovieDto movieDto)
        {
            return new Movie(movieDto);
        }
        public static MovieDto ToDto(Movie movie)
        {
            return new MovieDto(movie);
        }

        public static Review ToModel(ReviewDto reviewDto)
        {
            return new Review(reviewDto);
        }

        public static ReviewDto ToDto(Review review)
        {
            return new ReviewDto(review);
        }
    }
}
