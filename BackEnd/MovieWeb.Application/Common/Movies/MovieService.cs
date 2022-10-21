using Microsoft.EntityFrameworkCore;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Application.Common.Movies.Dtos;
using MovieWeb.Infrastructure.Persistence;

namespace MovieWeb.Application.Common.Movies
{
    public class MovieService : IMovieService
    {
        private readonly MovieDbContext dbContext;

        public MovieService(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
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
