﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTracker.DtoModels;
using MovieTracker.Models;
using MovieTracker.Services;

namespace MovieTracker.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieService movieService;
        private readonly MovieTrackerContext dbContext;

        public MovieController(MovieService movieService, MovieTrackerContext dbContext)
        {
            this.movieService = movieService;
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] MovieDto movieDto)
        {
            var movie = this.movieService.Create(movieDto);
            return Created("movie", movie);
        }

        [HttpGet]
        public IEnumerable<MovieDto> Get()
        {
            var moviesDto = this.movieService.GetAll();
            return moviesDto;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
           var movie = this.movieService.Get(id);
           return Ok(movie);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] MovieDto movieDto)
        {
            this.movieService.Update(id, movieDto);
            return Ok();
        }
    }
}

