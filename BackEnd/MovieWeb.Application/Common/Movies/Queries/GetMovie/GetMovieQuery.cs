using MediatR;
using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Movies.Queries.GetMovies
{
    public class GetMovieQuery : IRequest<MovieDetailDto>
    {
        public int MovieId { get; set; }
    }
}
