using MovieTracker.DtoModels;
using System;
using System.Collections.Generic;

namespace MovieTracker.Models
{
    public partial class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime WatchedOn { get; set; }

        public Movie() {}

        public Movie(MovieDto movieDto)
        {
            MovieId = movieDto.MovieId;
            Title = movieDto.Title;
            Description = movieDto.Description;
            CreatedOn = movieDto.CreatedOn;
            UpdatedOn = movieDto.UpdatedOn;
            IsDeleted = movieDto.IsDeleted;
            WatchedOn = movieDto.WatchedOn;

        }
    }
}
