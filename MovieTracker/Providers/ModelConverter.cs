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
    }
}
