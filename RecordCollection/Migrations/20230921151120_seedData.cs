using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordCollection.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "albums",
                columns: new[] { "id", "artist", "release_date", "title" },
                values: new object[,]
                {
                    { 1, "Pink Floyd", new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dark Side of the Moon" },
                    { 2, "The Beatles", new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Abbey Road" },
                    { 3, "Led Zeppelin", new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Led Zeppelin IV" },
                    { 4, "Fleetwood Mac", new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Rumours" },
                    { 5, "Pink Floyd", new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "The Wall" },
                    { 6, "The Beatles", new DateTime(1966, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Revolver" },
                    { 7, "Led Zeppelin", new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Led Zeppelin II" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
