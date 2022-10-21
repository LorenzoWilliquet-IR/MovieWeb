using MovieWeb.Application.Common.Actors.Dtos;

namespace MovieWeb.Application.Common.Movies.Dtos
{
    public class MovieDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<GetActorDto> Actors { get; set; } = new List<GetActorDto>();
    }
}
