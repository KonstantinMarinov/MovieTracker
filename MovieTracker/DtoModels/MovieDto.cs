using MovieTracker.Models;

namespace MovieTracker.DtoModels
{
    public class MovieDto
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public DateTime WatchedOn { get; set; }

        public MovieDto (Movie movie )
        {
            this.MovieId = movie.MovieId;
            this.Title = movie.Title;
            this.WatchedOn = movie.WatchedOn;
        }
        public MovieDto()
        {

        }
    }
}
