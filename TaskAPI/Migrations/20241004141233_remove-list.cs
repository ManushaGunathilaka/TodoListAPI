using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class removelist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 10, 9, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 10, 6, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 10, 7, 19, 42, 33, 336, DateTimeKind.Local).AddTicks(8702) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 10, 9, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1066), new DateTime(2024, 10, 6, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 10, 7, 17, 34, 2, 282, DateTimeKind.Local).AddTicks(1069) });
        }
    }
}
