using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Application.Common.Movies.Dtos;
using MovieWeb.Domain;
using MovieWeb.Infrastructure.Persistence;

namespace MovieWeb.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieDbContext dbContext;
        private readonly IMapper mapper;

        public MovieService(MovieDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<int> CreateMovieAsync(CreateMovieDto movie)
        {
            if (movie == null)
                throw new ArgumentNullException("CreateMovieDto should not be null.");

            var newMovie = mapper.Map<Movie>(movie);

            await dbContext.Movies.AddAsync(newMovie);
            await dbContext.SaveChangesAsync(default);

            return newMovie.Id;
        }

        public async Task<MovieDto[]> GetMoviesAsync()
        {
            var orders = await dbContext.Movies
                .Select(o => new MovieDto
                {
                    Id = o.Id,
                    Name = o.Name,
                })
                .ToArrayAsync();

            return orders;
        }
    }
}
