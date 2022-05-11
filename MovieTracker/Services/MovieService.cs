using Microsoft.AspNetCore.Mvc;
using MovieTracker.DtoModels;
using MovieTracker.Models;
using MovieTracker.Providers;

namespace MovieTracker.Services
{
    public class MovieService
    {
        private readonly MovieTrackerContext dbContext;

        public MovieService(MovieTrackerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Movie GetDbModel(Guid id)
        {
            var movie = this.dbContext.Movies.FirstOrDefault(x => x.MovieId == id);
            return movie;
        }
        public MovieDto Create(MovieDto movieDto)
        {
            Verification.CheckTitleLength(movieDto.Title);
            var movie = ModelConverter.ToModel(movieDto);
            movie.MovieId = GuidGenerator.Generate();
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
            var dto = ModelConverter.ToDto(movie);
            return dto;

        }

        public IEnumerable<MovieDto> GetAll()
        {
            var movies = this.dbContext.Movies.ToList();
            List<MovieDto> dtoList = new List<MovieDto>();
            foreach (var movie in movies)
            {
                dtoList.Add(ModelConverter.ToDto(movie));
            }
            return dtoList;
        }

        public MovieDto Get(Guid id)
        {
            var movie = GetDbModel(id);
            var dto = ModelConverter.ToDto(movie);
            return dto;
        }

        public void Update(Guid id, MovieDto movieDto)
        {
            var movie = GetDbModel(id);
            movie.Title = movieDto.Title;
            dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var movie = GetDbModel(id);
            dbContext.Movies.Remove(movie);
            dbContext.SaveChanges();
        }
    }
}
