using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTracker.DtoModels;
using MovieTracker.Models;
using MovieTracker.Services;

namespace MovieTracker.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewService reviewService;
        private readonly MovieTrackerContext dbContext;

        public ReviewController(ReviewService reviewService, MovieTrackerContext dbContext)
        {
            this.reviewService = reviewService;
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ReviewDto reviewDto)
        {
            var review = this.reviewService.Create(reviewDto);
            return Created("review", review);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var review = this.reviewService.GetAll();
            return Ok(review);
        }
    }
}
