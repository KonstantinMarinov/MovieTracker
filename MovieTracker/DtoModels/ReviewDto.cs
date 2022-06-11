using MovieTracker.Models;

namespace MovieTracker.DtoModels
{
    public class ReviewDto
    {
        public Guid ReviewId { get; set; }
        public Guid MovieId { get; set; }
        public string Author { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int Rating { get; set; }

        public ReviewDto(Review review)
        {
            this.ReviewId = review.ReviewId;
            this.MovieId = review.MovieId;
            this.Author = review.Author;
            this.Text = review.Text;
            this.CreatedOn = DateTime.Now;
            this.UpdatedOn = DateTime.Now;
            this.IsDeleted = review.IsDeleted;
            this.Rating = review.Rating;
        }



    }
}
