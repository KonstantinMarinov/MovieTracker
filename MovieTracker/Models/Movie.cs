using MovieTracker.DtoModels;
using System;
using System.Collections.Generic;

namespace MovieTracker.Models
{
    public partial class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime WatchedOn { get; set; }

        public Movie(MovieDto movieDto)
        {
            this.MovieId = movieDto.MovieId;
            this.Title = movieDto.Title;
            this.WatchedOn = movieDto.WatchedOn;
        }

        public Movie()
        {

        }
    }
}
