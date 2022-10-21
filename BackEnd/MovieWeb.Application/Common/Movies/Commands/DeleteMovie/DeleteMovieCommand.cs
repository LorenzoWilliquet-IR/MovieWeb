using MediatR;

namespace MovieWeb.Application.Common.Movies.Commands.DeleteMovie
{
    public class DeleteMovieCommand : IRequest<bool>
    {
        public int MovieId { get; set; }
    }
}
