using MovieTracker.DtoModels;
using MovieTracker.Models;
using MovieTracker.Providers;

namespace MovieTracker.Services
{
    public class ReviewService
    {
        private readonly MovieTrackerContext dbContext;

        public ReviewService(MovieTrackerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Review GetDbModel(Guid id)
        {
            var review = this.dbContext.Reviews.FirstOrDefault(x => x.MovieId == id);
            return review;
        }

        public ReviewDto Create(ReviewDto reviewDto)
        {
            var review = ModelConverter.ToModel(reviewDto);
            review.ReviewId = GuidGenerator.Generate();
            dbContext.Reviews.Add(review);
            dbContext.SaveChanges();
            var dto = ModelConverter.ToDto(review);
            return dto;
        }

        public IEnumerable<ReviewDto> GetAll()
        {
            var reviews = this.dbContext.Reviews.ToList();
            List<ReviewDto> dtoList = new List<ReviewDto>();
            foreach (var review in reviews)
            {
                dtoList.Add(ModelConverter.ToDto(review));
            }
            return dtoList;
        }


    }
}
