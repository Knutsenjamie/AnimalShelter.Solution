using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                new Animal { AnimalId = 1, Name = "Peppermint", Breed = "Tuxedo", Type = "Cat", Description = "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.", Age = 7, Gender = "Male"},
                
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}