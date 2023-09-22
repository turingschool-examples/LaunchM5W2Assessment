using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordCollection.Migrations
{
    /// <inheritdoc />
    public partial class moreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "albums",
                columns: new[] { "id", "artist", "release_date", "title" },
                values: new object[,]
                {
                    { 8, "Billie Eilish", new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "When We All Fall Asleep, Where Do We Go?" },
                    { 9, "Lake Street Dive", new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Obviously" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "albums",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
