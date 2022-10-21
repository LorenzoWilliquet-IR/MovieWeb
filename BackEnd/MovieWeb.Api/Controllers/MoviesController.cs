using AutoMapper;
using MediatR;
using Microservices.Orders.Application.Common.Orders.Commands.CreateOrder;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Application.Common.Movies.Dtos;
using MovieWeb.Application.Common.Movies.Queries.GetMovies;
using MovieWeb.Application.Services;
using MovieWeb.Domain;

namespace MovieWeb.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MoviesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        /// <summary>
        /// Get a single movie
        /// </summary>
        /// <returns>Movie</returns>
        [HttpGet("movie")]
        public async Task<IActionResult> GetMovie(int id)
        {
            return Ok(await _mediator.Send(new GetMovieQuery() { MovieId = id }));
        }

        /// <summary>
        /// Get a movie list
        /// </summary>
        /// <returns>Movie list</returns>
        [HttpGet("movies")]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _mediator.Send(new GetMoviesQuery()));
        }


        /// <summary>
        /// Create a new movie
        /// </summary>
        /// <returns>Movie id</returns>
        [HttpPost("movie")]
        public async Task<ActionResult> Create([FromBody] CreateMovieDto movieDto)
        {
            var movie = await _mediator.Send(new CreateMovieCommand() { CreateMovieDto = movieDto });

            return Ok(movie);
        }
    }
}
