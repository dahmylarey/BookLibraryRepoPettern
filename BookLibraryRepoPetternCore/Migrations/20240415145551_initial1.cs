using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLibraryRepoPetternCore.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "Description", "Genre", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Damilare oladele", null, "Display info about the Book.", "Asian", new DateTime(2024, 4, 15, 15, 55, 50, 931, DateTimeKind.Local).AddTicks(957), "Eternal secred king" },
                    { 2, "James wood", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 15, 15, 55, 50, 931, DateTimeKind.Local).AddTicks(968), "Legend of swordsMan" },
                    { 3, "muller james", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 15, 15, 55, 50, 931, DateTimeKind.Local).AddTicks(969), "Walker of Worlds" },
                    { 4, "Ibrahim Oloto", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 15, 15, 55, 50, 931, DateTimeKind.Local).AddTicks(971), "Emperor Dominations" },
                    { 5, "chen Ming", null, "Display info about the Book.", "Asian", new DateTime(2024, 4, 15, 15, 55, 50, 931, DateTimeKind.Local).AddTicks(972), "Loaded With Persive Skills" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookId",
                table: "Books",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
