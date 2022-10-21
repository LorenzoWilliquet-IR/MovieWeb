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
                }
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
                }
            };

            foreach (var actor in actors)
            {
                context.Actors.Add(actor);
            }
            context.SaveChanges();
        }
    }
}
