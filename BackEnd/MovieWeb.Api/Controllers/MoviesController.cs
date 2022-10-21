using AutoMapper;
using MediatR;
using Microservices.Orders.Application.Common.Orders.Commands.CreateOrder;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Application.Common.Movies.Commands.DeleteMovie;
using MovieWeb.Application.Common.Movies.Commands.UpdateMovie;
using MovieWeb.Application.Common.Movies.Dtos;
using MovieWeb.Application.Common.Movies.Queries.GetMovies;
using MovieWeb.Domain;

namespace MovieWeb.Api.Controllers
{
    [ApiController]
    [Route("api/movies")]
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
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            return Ok(await _mediator.Send(new GetMovieQuery() { MovieId = id }));
        }

        /// <summary>
        /// Get a movie list
        /// </summary>
        /// <returns>Movie list</returns>
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _mediator.Send(new GetMoviesQuery()));
        }


        /// <summary>
        /// Create a new movie
        /// </summary>
        /// <returns>Movie id</returns>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateMovieDto movieDto)
        {
            var movie = await _mediator.Send(new CreateMovieCommand() { CreateMovieDto = movieDto });

            return Ok(movie);
        }

        /// <summary>
        /// Update an existing movie
        /// </summary>
        /// <returns>Movie</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateMovieDto movieDto)
        {
            var movie = await _mediator.Send(new UpdateMovieCommand() { UpdateMovieDto = movieDto, MovieId = id });

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        /// <summary>
        /// Delete an existing movie
        /// </summary>
        /// <returns>Movie id</returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var response = await _mediator.Send(new DeleteMovieCommand() { MovieId = id });

            return Ok(response);
        }
    }
}
