using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fakeflix.Membership.Database.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chloé Zhao" },
                    { 2, "Ava DuVernay" },
                    { 3, "Kathryn Bigelow" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Sci-Fi" },
                    { 3, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "DirectorId", "FilmUrl", "Free", "Released", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum", 1, "https://www.youtube.com/watch?v=yFQyrYSvqPI", true, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Woman" },
                    { 2, "Lorem ipsum", 1, "https://www.youtube.com/watch?v=IkOK8tdEsFY", true, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hulk" },
                    { 3, "Lorem ipsum", 2, "https://www.youtube.com/watch?v=DKP16d_WdZM", true, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat Woman" },
                    { 4, "Lorem ipsum", 2, "https://www.youtube.com/watch?v=CsGYh8AacgY", true, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Sorcerers Stone" },
                    { 5, "Lorem ipsum", 3, "https://www.youtube.com/watch?v=jNQXAC9IVRw", true, new DateTime(2012, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { 6, "Lorem ipsum", 3, "https://www.youtube.com/watch?v=QH2-TGUlwu4", true, new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars : A New Hope" },
                    { 7, "Lorem ipsum", 3, "https://www.youtube.com/watch?v=e_04ZrNroTo", true, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: The Force Awakens" },
                    { 8, "Lorem ipsum", 1, "https://www.youtube.com/watch?v=L0MK7qz13bU", true, new DateTime(2002, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: The Last Jedi" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 }
                });

            migrationBuilder.InsertData(
                table: "SimilarFilms",
                columns: new[] { "FilmId", "SimilarFilmId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 4, 5 },
                    { 5, 4 },
                    { 6, 7 },
                    { 6, 8 },
                    { 7, 6 },
                    { 7, 8 },
                    { 8, 6 },
                    { 8, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "SimilarFilms",
                keyColumns: new[] { "FilmId", "SimilarFilmId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
