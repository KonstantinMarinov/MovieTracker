using MovieTracker.Models;

namespace MovieTracker.DtoModels
{
    public class MovieDto
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime WatchedOn { get; set; }

        public MovieDto (Movie movie )
        {
            this.MovieId = movie.MovieId;
            this.Title = movie.Title;
            this.Description = movie.Description;
            this.CreatedOn = movie.CreatedOn;
            this.WatchedOn = movie.WatchedOn;
        }
        public MovieDto()
        {

        }
    }
}
