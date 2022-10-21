using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Domain;

namespace MovieWeb.Application.Common.Interfaces
{
    public interface IActorService
    {
        Task<GetActorsDto[]> GetActorsAsync();
        Task<GetActorDto> GetActorAsync(int id);
        Task<bool> CreateActorAsync(Actor actor);
        Task<bool> UpdateActorAsync(int id, Actor actor);
        Task<bool> DeleteActorAsync(int id);

    }
}
