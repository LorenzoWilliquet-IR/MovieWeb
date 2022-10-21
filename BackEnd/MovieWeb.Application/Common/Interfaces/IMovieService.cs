using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Interfaces
{
    public interface IMovieService
    {
        Task<MovieDetailDto> GetMovieAsync(int id);
        Task<MovieDto[]> GetMoviesAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="createMovie"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        Task<int> CreateMovieAsync(CreateMovieDto movie);

        Task<int> DeleteMovieAsync(int id);
    }
}
