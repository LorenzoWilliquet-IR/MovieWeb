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

        public async Task<MovieDetailDto> GetMovieAsync(int id)
        {
            var movie = await dbContext.Movies
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();

            if (movie == null)
                return null;

            var movieDetailDto = new MovieDetailDto()
            {
                Id = id,
                Name = movie.Name,
                ReleaseDate = movie.ReleaseDate,
                DurationInMinutes = movie.DurationInMinutes
            };

            return movieDetailDto;
        }

        public async Task<MovieDto[]> GetMoviesAsync()
        {
            var movies = await dbContext.Movies
                .Select(o => new MovieDto
                {
                    Id = o.Id,
                    Name = o.Name,
                })
                .ToArrayAsync();

            return movies;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await dbContext.Movies
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();

            if (movie == null)
                return false;

            dbContext.Movies.Remove(movie);
            await dbContext.SaveChangesAsync(default);

            return true;
        }
    }
}
