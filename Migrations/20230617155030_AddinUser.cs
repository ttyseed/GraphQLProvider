using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQLSampleAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddinUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4f266d7c-e925-4008-ba43-ff7415eccf4a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("56d0072b-97d0-43f0-94ba-01bb719302e2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("871345f3-be5d-434e-8470-36a2377c71c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9f829e27-dd58-4251-a566-aa580caf7a24"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9fb0d225-0f20-4d78-9d67-81408b25a684"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d8a47851-a220-41ea-ac94-a030d00c6867"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e0eb7c4a-e4ac-4cf4-9653-d27d477e373d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("5af9cf75-f310-4baf-a458-7efe7f5305a8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("5e0679e6-740a-46c0-986e-3ea7f4045e10"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("869fd75a-644f-4b65-bd9b-a76957ac159a"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("afde177f-6997-4ad9-864f-5056cf22253e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cef4b572-6fd9-4c1f-8b14-cae2e2368bef"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d142b551-ef62-4571-951c-73dc5489c503"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fd211a83-912e-4df4-8402-a6a99ffebed6"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("5659132b-1795-486d-a22b-0a5f867bd660"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("95c27e85-b10a-454b-982a-174e0574a843"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("0929c010-420f-4867-81df-3e100696f980"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("181c3de7-afc3-4f63-b679-5af1607e253f"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("021e7750-4b51-4692-ac2f-c82fee1b463d"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("02c537ba-1c74-413b-94cb-c65207e7815e"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("181c3de7-afc3-4f63-b679-5af1607e253f"), "Black Widow" },
                    { new Guid("04d888ba-03cd-467b-8573-5a07c52b3c1e"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("39c7fac9-b5a0-47a2-930e-1ce39a744193"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0929c010-420f-4867-81df-3e100696f980"), "The Dark Knight" },
                    { new Guid("5d0bf60a-ea0b-4dc4-ae20-08ebc17ba6dd"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0929c010-420f-4867-81df-3e100696f980"), "Batman Begins" },
                    { new Guid("8ff5b605-2b95-44f5-9e10-ff0b75071ff1"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("ddb8f81e-6d13-41db-aa2e-a5e9e022eb70"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0929c010-420f-4867-81df-3e100696f980"), "The Dark Knight Rises" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("17ae64dc-2b5b-4719-848e-122c92c68b0c"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78") },
                    { new Guid("25a2c5c3-d5aa-4034-9062-736aef905bb2"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("181c3de7-afc3-4f63-b679-5af1607e253f") },
                    { new Guid("27fe1338-17aa-46ea-99b7-30338d771f98"), "He's always a step ahead.", "Intellect.", new Guid("0929c010-420f-4867-81df-3e100696f980") },
                    { new Guid("2f953d88-71b1-4994-a668-41bd88297410"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("181c3de7-afc3-4f63-b679-5af1607e253f") },
                    { new Guid("75d0e029-ee3e-48cf-a92d-d5d5d96cc100"), "She's good at spying at people.", "Espionage", new Guid("181c3de7-afc3-4f63-b679-5af1607e253f") },
                    { new Guid("9b367ba7-e768-4cb3-a466-d099e0197f69"), "He got a lot of money", "Wealth.", new Guid("0929c010-420f-4867-81df-3e100696f980") },
                    { new Guid("ce762baf-d560-4916-a817-86b8f7fe8dc8"), "Sublime fighting skills.", "Fighting", new Guid("0929c010-420f-4867-81df-3e100696f980") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("021e7750-4b51-4692-ac2f-c82fee1b463d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("02c537ba-1c74-413b-94cb-c65207e7815e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("04d888ba-03cd-467b-8573-5a07c52b3c1e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("39c7fac9-b5a0-47a2-930e-1ce39a744193"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5d0bf60a-ea0b-4dc4-ae20-08ebc17ba6dd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8ff5b605-2b95-44f5-9e10-ff0b75071ff1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ddb8f81e-6d13-41db-aa2e-a5e9e022eb70"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("17ae64dc-2b5b-4719-848e-122c92c68b0c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("25a2c5c3-d5aa-4034-9062-736aef905bb2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("27fe1338-17aa-46ea-99b7-30338d771f98"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("2f953d88-71b1-4994-a668-41bd88297410"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("75d0e029-ee3e-48cf-a92d-d5d5d96cc100"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9b367ba7-e768-4cb3-a466-d099e0197f69"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ce762baf-d560-4916-a817-86b8f7fe8dc8"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("0929c010-420f-4867-81df-3e100696f980"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("181c3de7-afc3-4f63-b679-5af1607e253f"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("45a0df2e-1816-4a92-9d35-6c625efb3b78"));

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("5659132b-1795-486d-a22b-0a5f867bd660"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("95c27e85-b10a-454b-982a-174e0574a843"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("4f266d7c-e925-4008-ba43-ff7415eccf4a"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5659132b-1795-486d-a22b-0a5f867bd660"), "Black Widow" },
                    { new Guid("56d0072b-97d0-43f0-94ba-01bb719302e2"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d"), "The Dark Knight" },
                    { new Guid("871345f3-be5d-434e-8470-36a2377c71c3"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d"), "The Dark Knight Rises" },
                    { new Guid("9f829e27-dd58-4251-a566-aa580caf7a24"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d"), "Batman Begins" },
                    { new Guid("9fb0d225-0f20-4d78-9d67-81408b25a684"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("95c27e85-b10a-454b-982a-174e0574a843"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("d8a47851-a220-41ea-ac94-a030d00c6867"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("95c27e85-b10a-454b-982a-174e0574a843"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("e0eb7c4a-e4ac-4cf4-9653-d27d477e373d"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("95c27e85-b10a-454b-982a-174e0574a843"), "Star Wars: Episode V – The Empire Strikes Back" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("5af9cf75-f310-4baf-a458-7efe7f5305a8"), "He's always a step ahead.", "Intellect.", new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d") },
                    { new Guid("5e0679e6-740a-46c0-986e-3ea7f4045e10"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("5659132b-1795-486d-a22b-0a5f867bd660") },
                    { new Guid("869fd75a-644f-4b65-bd9b-a76957ac159a"), "Sublime fighting skills.", "Fighting", new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d") },
                    { new Guid("afde177f-6997-4ad9-864f-5056cf22253e"), "She's good at spying at people.", "Espionage", new Guid("5659132b-1795-486d-a22b-0a5f867bd660") },
                    { new Guid("cef4b572-6fd9-4c1f-8b14-cae2e2368bef"), "He got a lot of money", "Wealth.", new Guid("8de642ea-65d0-4758-b6a8-a0b0c3ea075d") },
                    { new Guid("d142b551-ef62-4571-951c-73dc5489c503"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("5659132b-1795-486d-a22b-0a5f867bd660") },
                    { new Guid("fd211a83-912e-4df4-8402-a6a99ffebed6"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("95c27e85-b10a-454b-982a-174e0574a843") }
                });
        }
    }
}
