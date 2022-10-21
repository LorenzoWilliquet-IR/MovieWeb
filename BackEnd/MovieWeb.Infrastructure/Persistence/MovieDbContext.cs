using Microsoft.EntityFrameworkCore;
using MovieWeb.Domain;

namespace MovieWeb.Infrastructure.Persistence
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies => Set<Movie>();

        public MovieDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Movie>()
                .HasKey(t => t.Id);

            modelBuilder
                .Entity<Movie>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
