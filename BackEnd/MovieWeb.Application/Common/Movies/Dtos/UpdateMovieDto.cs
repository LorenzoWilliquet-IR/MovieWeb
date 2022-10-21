namespace MovieWeb.Application.Common.Movies.Dtos
{
    public class UpdateMovieDto
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
