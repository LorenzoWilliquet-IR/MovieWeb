using AutoMapper;
using MovieWeb.Application.Common.Movies.Dtos;
using MovieWeb.Domain;

namespace MovieWeb.Api.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<CreateMovieDto, Movie>();
            CreateMap<MovieDetailDto, Movie>();
        }
    }
}
