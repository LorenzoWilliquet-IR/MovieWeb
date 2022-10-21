using MovieWeb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.Infrastructure.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Actors.Any())
            {
                return;
            }

            var actors = new Actor[]
            {
                new Actor()
                {
                    FirstName = "Brad", LastName = "Pitt", Birthdate =  new DateTime(1963,12,18)
                },
                new Actor()
                {
                    FirstName = "Johnny", LastName = "Depp", Birthdate =  new DateTime(1963,6,9)
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
