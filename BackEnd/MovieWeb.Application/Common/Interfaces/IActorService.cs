using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.Application.Common.Interfaces
{
    public interface IActorService
    {
        Task<GetActorsDto[]> GetActorsAsync();
        Task<Actor> GetActorAsync(int id);
        Task<bool> CreateActorAsync(Actor actor);
        Task<bool> UpdateActorAsync(int id, Actor actor);
        Task<bool> DeleteActorAsync(int id);

    }
}
