using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibraryRepoPetternCore.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotMappAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBook");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9620));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.CreateIndex(
                name: "IX_BookBook_JournalId",
                table: "BookBook",
                column: "JournalId");
        }
    }
}
