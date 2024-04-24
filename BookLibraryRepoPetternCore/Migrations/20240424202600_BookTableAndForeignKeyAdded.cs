using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLibraryRepoPetternCore.Migrations
{
    /// <inheritdoc />
    public partial class BookTableAndForeignKeyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tbl_AuthorAuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Authors", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_tbl_Authors_tbl_Authors_Tbl_AuthorAuthorId",
                        column: x => x.Tbl_AuthorAuthorId,
                        principalTable: "tbl_Authors",
                        principalColumn: "AuthorId");
                });

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
                    AuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_tbl_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "tbl_Authors",
                        principalColumn: "AuthorId");
                });

            migrationBuilder.CreateTable(
                name: "BookBook",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    JournalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBook", x => new { x.BooksId, x.JournalId });
                    table.ForeignKey(
                        name: "FK_BookBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBook_Books_JournalId",
                        column: x => x.JournalId,
                        principalTable: "Books",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AuthorId", "Description", "Genre", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Damilare oladele", null, "Display info about the Book.", "Asian", new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4694), "Eternal secred king" },
                    { 2, "James wood", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4708), "Legend of swordsMan" },
                    { 3, "muller james", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4709), "Walker of Worlds" },
                    { 4, "Ibrahim Oloto", null, "Display info about the Book.", "Cultivation", new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4710), "Emperor Dominations" },
                    { 5, "chen Ming", null, "Display info about the Book.", "Asian", new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4711), "Loaded With Persive Skills" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBook_JournalId",
                table: "BookBook",
                column: "JournalId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Authors_Tbl_AuthorAuthorId",
                table: "tbl_Authors",
                column: "Tbl_AuthorAuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBook");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "tbl_Authors");
        }
    }
}
