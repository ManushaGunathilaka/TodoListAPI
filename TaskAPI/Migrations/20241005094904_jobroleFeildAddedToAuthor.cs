using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class jobroleFeildAddedToAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Systems Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 10, 10, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 10, 7, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 10, 8, 15, 18, 56, 865, DateTimeKind.Local).AddTicks(538) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2538), new DateTime(2024, 10, 10, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2557), new DateTime(2024, 10, 7, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2560), new DateTime(2024, 10, 8, 9, 16, 43, 344, DateTimeKind.Local).AddTicks(2560) });
        }
    }
}
