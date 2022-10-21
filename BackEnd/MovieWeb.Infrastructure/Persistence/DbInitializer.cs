using MovieWeb.Domain;

namespace MovieWeb.Infrastructure.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //if (context.Actors.Any() || context.Movies.Any())
            //{
            //    return;
            //}

            var movies = new Movie[]
            {
                new Movie()
                {
                    Name = "Jaws", DurationInMinutes = 120, ReleaseDate = new DateTime(1999,12,10)
                },
                new Movie()
                {
                    Name = "The Lord of The Rings: Fellowship of the Ring", DurationInMinutes = 178, ReleaseDate = new DateTime(2001,12,19)
                },
                new Movie()
                {
                    Name = "Scream (2022)", DurationInMinutes = 114, ReleaseDate = new DateTime(2022,01,14)
                },
                new Movie()
                {
                    Name = "The Godfather", DurationInMinutes = 175, ReleaseDate = new DateTime(1973,01,18)
                },
                new Movie()
                {
                    Name = "The Incredibles", DurationInMinutes = 90, ReleaseDate = new DateTime(2010,01,18)
                },
            };

            foreach (var movie in movies)
            {
                context.Movies.Add(movie);
            }

            context.SaveChanges();

            var actors = new Actor[]
            {
                new Actor()
                {
                    FirstName = "Brad", LastName = "Pitt", Birthdate =  new DateTime(1963,12,18), MovieId = 1
                },
                new Actor()
                {
                    FirstName = "Johnny", LastName = "Depp", Birthdate =  new DateTime(1963,6,9), MovieId = 1
                },
                new Actor()
                {
                    FirstName = "Elijah", LastName = "Wood", Birthdate =  new DateTime(1963,6,9), MovieId = 2
                },
                new Actor()
                {
                    FirstName = "Jack", LastName = "Quaid", Birthdate =  new DateTime(1992,04,24), MovieId = 3
                },
                new Actor()
                {
                    FirstName = "Robert", LastName = "De Niro", Birthdate =  new DateTime(1972,6,9), MovieId = 4
                },
            };

            foreach (var actor in actors)
            {
                context.Actors.Add(actor);
            }
            context.SaveChanges();
        }
    }
}
