using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQLSampleAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddinSample : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0920f0b7-7fbd-4986-b5a1-7a03f2bad526"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("34a8f1e4-bc07-4d34-8c2d-99f068364a26"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4b865e22-c16e-4f02-b7e8-9b562b6565c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("778fde1e-4966-4ae7-90b2-c0a976022f31"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7fa51586-6443-409d-96f4-2777dbaeee0f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("92743577-b004-499e-b23e-9715fbd0cca3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a6e71634-6822-4e06-8019-4cec692288cd"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0966f666-3329-40f8-b252-f076fa53fe17"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("173b3c24-9f42-40d3-af9c-70c745acc5dc"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("36815a6d-64c9-49cf-8b8f-af099415c033"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("5ed3800c-6ec0-4c80-89c7-4ff11b53012d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7c969790-da38-400c-8799-a73867193d86"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("aa95d605-4f7e-4f49-9ff1-5f08447fe878"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f2e5cc2c-357d-48fd-82ff-e795beac02fb"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("57941cf0-fac7-4734-a707-95daca13e8b1"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47"));

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samples");

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

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("57941cf0-fac7-4734-a707-95daca13e8b1"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0920f0b7-7fbd-4986-b5a1-7a03f2bad526"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57941cf0-fac7-4734-a707-95daca13e8b1"), "Batman Begins" },
                    { new Guid("34a8f1e4-bc07-4d34-8c2d-99f068364a26"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57941cf0-fac7-4734-a707-95daca13e8b1"), "The Dark Knight Rises" },
                    { new Guid("4b865e22-c16e-4f02-b7e8-9b562b6565c9"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47"), "Black Widow" },
                    { new Guid("778fde1e-4966-4ae7-90b2-c0a976022f31"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("7fa51586-6443-409d-96f4-2777dbaeee0f"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("92743577-b004-499e-b23e-9715fbd0cca3"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57941cf0-fac7-4734-a707-95daca13e8b1"), "The Dark Knight" },
                    { new Guid("a6e71634-6822-4e06-8019-4cec692288cd"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74"), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0966f666-3329-40f8-b252-f076fa53fe17"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47") },
                    { new Guid("173b3c24-9f42-40d3-af9c-70c745acc5dc"), "He got a lot of money", "Wealth.", new Guid("57941cf0-fac7-4734-a707-95daca13e8b1") },
                    { new Guid("36815a6d-64c9-49cf-8b8f-af099415c033"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("4e460287-5798-484b-9a1e-87e2cbe70c74") },
                    { new Guid("5ed3800c-6ec0-4c80-89c7-4ff11b53012d"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47") },
                    { new Guid("7c969790-da38-400c-8799-a73867193d86"), "She's good at spying at people.", "Espionage", new Guid("99e796ee-60b1-48cb-a141-57be60f2fd47") },
                    { new Guid("aa95d605-4f7e-4f49-9ff1-5f08447fe878"), "He's always a step ahead.", "Intellect.", new Guid("57941cf0-fac7-4734-a707-95daca13e8b1") },
                    { new Guid("f2e5cc2c-357d-48fd-82ff-e795beac02fb"), "Sublime fighting skills.", "Fighting", new Guid("57941cf0-fac7-4734-a707-95daca13e8b1") }
                });
        }
    }
}
