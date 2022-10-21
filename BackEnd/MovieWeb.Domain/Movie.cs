namespace MovieWeb.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
