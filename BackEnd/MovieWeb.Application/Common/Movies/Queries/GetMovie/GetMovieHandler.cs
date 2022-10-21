using MediatR;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Movies.Queries.GetMovies
{
    public class GetMovieHandler : IRequestHandler<GetMovieQuery, MovieDetailDto>
    {
        private readonly IMovieService movieService;

        public GetMovieHandler(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<MovieDetailDto> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            return await movieService.GetMovieAsync(request.MovieId);
        }
    }
}
