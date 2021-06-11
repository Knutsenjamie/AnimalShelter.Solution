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
                new Animal { AnimalId = 1, Name = "Peppermint", Breed = "Tuxedo", Type = "Cat", Description = "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it. Adopt this sweet adult kitty today!", Age = 7, Gender = "Male"},
                new Animal { AnimalId = 2, Name = "Weenie", Breed = "Dachshund", Type = "Dog", Description = "Even though he's got somewhat of a fiesty personality; Weenie is your average, loveable, Dachshund. His favorite toy is a giant stuffed pickle that makes crinkly sounds. Adopt Weenie today!", Age = 1, Gender = "Male"},
                new Animal { AnimalId = 3, Name = "Lasagna", Breed = "Orange Tabby", Type = "Cat", Description = "Lasagna is your typical, spunky little kitten. He loves to zoomie around and play with anything that moves honestly. Lasagna is the perfect addition for a family with young children. Adopt today!", Age = 1, Gender = "Male"},
                new Animal { AnimalId = 4, Name = "Peanut Butter", Breed = "Rottweiler", Type = "Dog", Description = "Looking for a loyal friend and protector of your home? Peanut Butter is the perfect combination of sweet, friendly, protective and loyal. Rescued from a hording situation, Peanut Butter has come a long way through our rehab program for rescues. Her favorite toy is a classic tennis ball to play fetch with. Adopt this deserving pupper today!", Age = 4, Gender = "Female"},
                new Animal { AnimalId = 5, Name = "Smeagol", Breed = "Likoi", Type = "Cat", Description = "One of the shelters first werewolf cats, Smeagol is a sweet little lady who enjoys snuggling up and cuddling. Smeagol was a rescue from a bad breeding situation, but has aced our rehab program and is ready for a forever home! Her favorite thing ever is catnip. Bring Smeagol home today!", Age = 4, Gender = "Female"},
                new Animal { AnimalId = 6, Name = "Aki", Breed = "Shiba Inu", Type = "Dog", Description = "Do you love to hike? Do you want a pup that will be your best outdoorsy friend? Aki the energetic and loving Shiba Inu is perfect for your family! Aki loves to get down and dirty and play in the mud sometimes, but give her a bath and she'll enjoy that just as much. Bring Aki home today!", Age = 2, Gender = "Female"},
                new Animal { AnimalId = 7, Name = "Pierre", Breed = "Blue Iguana", Type = "Iguana", Description = "One of our only other species available, Pierre is a Blue Iguana that was rescued from a sketchy tropical pet store. Pierre is quiet, but will bring joy to any reptile-experienced family that passes a basic background check. Pierre likes to sun himself- especially on his favorite rock. If you qualify, adopt this big loveable dude today!", Age = 5, Gender = "Male"}
              
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}