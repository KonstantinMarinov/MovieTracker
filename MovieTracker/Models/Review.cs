using MovieTracker.DtoModels;
using System;
using System.Collections.Generic;

namespace MovieTracker.Models
{
    public partial class Review
    {
        public Guid ReviewId { get; set; }
        public Guid MovieId { get; set; }
        public string Author { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int Rating { get; set; }

        public Review() { }

        public Review(ReviewDto reviewDto)
        {
            this.ReviewId = reviewDto.ReviewId;
            this.MovieId = reviewDto.MovieId;
            this.Author = reviewDto.Author;
            this.Text = reviewDto.Text;
            this.CreatedOn = reviewDto.CreatedOn;
            this.UpdatedOn = reviewDto.UpdatedOn;
            this.Rating = reviewDto.Rating;
            this.IsDeleted = reviewDto.IsDeleted;
        }
    }
}
