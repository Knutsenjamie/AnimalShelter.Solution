using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Gender", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 7, "Tuxedo", "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it. Adopt this sweet adult kitty today!", "Male", "Peppermint", "Cat" },
                    { 2, 1, "Dachshund", "Even though he's got somewhat of a fiesty personality; Weenie is your average, loveable, Dachshund. His favorite toy is a giant stuffed pickle that makes crinkly sounds. Adopt Weenie today!", "Male", "Weenie", "Dog" },
                    { 3, 1, "Orange Tabby", "Lasagna is your typical, spunky little kitten. He loves to zoomie around and play with anything that moves honestly. Lasagna is the perfect addition for a family with young children. Adopt today!", "Male", "Lasagna", "Cat" },
                    { 4, 4, "Rottweiler", "Looking for a loyal friend and protector of your home? Peanut Butter is the perfect combination of sweet, friendly, protective and loyal. Rescued from a hording situation, Peanut Butter has come a long way through our rehab program for rescues. Her favorite toy is a classic tennis ball to play fetch with. Adopt this deserving pupper today!", "Female", "Peanut Butter", "Dog" },
                    { 5, 4, "Likoi", "One of the shelters first werewolf cats, Smeagol is a sweet little lady who enjoys snuggling up and cuddling. Smeagol was a rescue from a bad breeding situation, but has aced our rehab program and is ready for a forever home! Her favorite thing ever is catnip. Bring Smeagol home today!", "Female", "Smeagol", "Cat" },
                    { 6, 2, "Shiba Inu", "Do you love to hike? Do you want a pup that will be your best outdoorsy friend? Aki the energetic and loving Shiba Inu is perfect for your family! Aki loves to get down and dirty and play in the mud sometimes, but give her a bath and she'll enjoy that just as much. Bring Aki home today!", "Female", "Aki", "Dog" },
                    { 7, 5, "Blue Iguana", "One of our only other species available, Pierre is a Blue Iguana that was rescued from a sketchy tropical pet store. Pierre is quiet, but will bring joy to any reptile-experienced family that passes a basic background check. Pierre likes to sun himself- especially on his favorite rock. If you qualify, adopt this big loveable dude today!", "Male", "Pierre", "Iguana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
