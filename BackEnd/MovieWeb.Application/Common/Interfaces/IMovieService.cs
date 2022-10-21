using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Interfaces
{
    public interface IMovieService
    {
        Task<MovieDto[]> GetMoviesAsync();
    }
}
