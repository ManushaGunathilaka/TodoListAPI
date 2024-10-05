using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class Author_Entity_And_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Manusha Gunathilaka" },
                    { 2, "Methsara Dissanayaka" },
                    { 3, "Kalpa Wishwajith" },
                    { 4, "Kusal Mendis" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Description", "Due", "Title" },
                values: new object[] { 1, new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1044), "Finish the report for the upcoming project deadline.", new DateTime(2024, 10, 9, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1055), "Complete Project Report" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1066), "Prepare slides and notes for Monday's presentation.", new DateTime(2024, 10, 6, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1067), 1, "Prepare for Presentation" },
                    { 3, 2, new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1069), "Schedule a meeting with the team to discuss project progress.", new DateTime(2024, 10, 7, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1069), 0, "Team Meeting" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Description", "Due", "Title" },
                values: new object[] { new DateTime(2024, 10, 4, 14, 19, 49, 134, DateTimeKind.Local).AddTicks(9692), "Description for Test 1 - DB", new DateTime(2024, 10, 5, 14, 19, 49, 134, DateTimeKind.Local).AddTicks(9705), "Test 1" });
        }
    }
}
