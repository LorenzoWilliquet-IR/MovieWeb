namespace MovieWeb.Application.Common.Actors.Dtos
{
    public class GetActorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
