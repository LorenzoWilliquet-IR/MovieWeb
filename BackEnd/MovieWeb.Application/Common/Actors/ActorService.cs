using AutoMapper;
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
        private readonly IMapper mapper;

        public ActorService(MovieDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public Task<bool> CreateActorAsync(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetActorDto> GetActorAsync(int id)
        {
            var actor = await dbContext.Actors
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var actorDto = mapper.Map<GetActorDto>(actor);

            return actorDto;
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
