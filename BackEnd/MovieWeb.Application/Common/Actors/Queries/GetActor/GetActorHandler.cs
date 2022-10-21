using MediatR;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Application.Common.Interfaces;

namespace MovieWeb.Application.Common.Movies.Queries.GetMovies
{
    public class GetActorHandler : IRequestHandler<GetActorQuery, GetActorDto>
    {
        private readonly IActorService actorService;

        public GetActorHandler(IActorService actorService)
        {
            this.actorService = actorService;
        }

        public async Task<GetActorDto> Handle(GetActorQuery request, CancellationToken cancellationToken)
        {
            return await actorService.GetActorAsync(request.ActorId);
        }
    }
}
