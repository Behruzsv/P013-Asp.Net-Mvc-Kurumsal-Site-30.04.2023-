using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorev7P013.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2023, 5, 7, 20, 43, 47, 89, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2023, 5, 7, 20, 43, 47, 89, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 5, 7, 20, 43, 47, 89, DateTimeKind.Local).AddTicks(8312));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2023, 5, 7, 20, 40, 22, 703, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2023, 5, 7, 20, 40, 22, 703, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 5, 7, 20, 40, 22, 703, DateTimeKind.Local).AddTicks(3429));
        }
    }
}
