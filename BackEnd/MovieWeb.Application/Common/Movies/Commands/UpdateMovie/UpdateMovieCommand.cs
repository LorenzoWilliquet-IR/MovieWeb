using MediatR;
using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Movies.Commands.UpdateMovie
{
    public class UpdateMovieCommand : IRequest<bool>
    {
        public int MovieId { get; set; }
        public UpdateMovieDto UpdateMovieDto { get; set; }
    }
}
