using MediatR;
using MovieWeb.Application.Common.Actors.Dtos;

namespace MovieWeb.Application.Common.Actors.Queries.GetActors
{
    public class GetActorsQuery : IRequest<GetActorsDto[]>
    {

    }
}
