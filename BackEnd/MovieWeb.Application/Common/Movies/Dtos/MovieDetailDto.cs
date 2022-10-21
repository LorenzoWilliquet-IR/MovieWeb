namespace MovieWeb.Application.Common.Movies.Dtos
{
    public class MovieDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
