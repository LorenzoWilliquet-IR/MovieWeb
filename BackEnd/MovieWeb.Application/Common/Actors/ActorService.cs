using Microsoft.EntityFrameworkCore;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Domain;
using MovieWeb.Infrastructure.Persistence;

namespace MovieWeb.Application.Common.Actors
{
    public class ActorService : IActorService
    {
        private readonly MovieDbContext dbContext;

        public ActorService(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<bool> CreateActorAsync(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetActorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetActorsDto[]> GetActorsAsync()
        {
            var actors = await dbContext.Actors
                .Select(x => new GetActorsDto
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                })
                .ToArrayAsync();
            return actors;
        }

        public Task<bool> UpdateActorAsync(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
