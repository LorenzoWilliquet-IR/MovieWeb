using MediatR;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Application.Common.Movies.Dtos;

namespace MovieWeb.Application.Common.Movies.Queries.GetMovies
{
    public class GetActorQuery : IRequest<GetActorDto>
    {
        public int ActorId { get; set; }
    }
}
