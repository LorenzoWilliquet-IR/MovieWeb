using MediatR;

namespace MovieWeb.Application.Common.Movies.Commands.DeleteMovie
{
    public class DeleteMovieCommand : IRequest<int>
    {
        public int MovieId { get; set; }
    }
}
