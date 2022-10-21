using MediatR;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Application.Common.Interfaces;

namespace MovieWeb.Application.Common.Actors.Queries.GetActors
{
    public class GetActorsHandler : IRequestHandler<GetActorsQuery, GetActorsDto[]>
    {
        private readonly IActorService _actorService;

        public GetActorsHandler(IActorService actorService)
        {
            _actorService = actorService;
        }

        public async Task<GetActorsDto[]> Handle(GetActorsQuery request, CancellationToken cancellationToken)
        {
            return await _actorService.GetActorsAsync();
        }
    }
}
