using MediatR;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Movies.Queries.GetMovies
{
    public class GetMoviesHandler : IRequestHandler<GetMoviesQuery, MovieDto[]>
    {
        private readonly IMovieService movieService;

        public GetMoviesHandler(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<MovieDto[]> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await movieService.GetMoviesAsync();
        }
    }
}
