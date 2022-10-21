using AutoMapper;
using MovieWeb.Application.Common.Actors.Dtos;
using MovieWeb.Domain;

namespace MovieWeb.Api.Profiles
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
            CreateMap<Actor, GetActorsDto>().ReverseMap();
            CreateMap<Actor, CreateActorDto>().ReverseMap();
            CreateMap<Actor, GetActorDto>().ReverseMap();
            CreateMap<Actor, UpdateActorDto>().ReverseMap();
        }
    }
}
