using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental_DVT.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 314, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "Price", "ReturnDate" },
                values: new object[] { 12.0, new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                columns: new[] { "Director", "VideoName" },
                values: new object[] { "Curtis Hanson", "8 Mile" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 9, 58, 56, 940, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "Price", "ReturnDate" },
                values: new object[] { 22.0, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                columns: new[] { "Director", "VideoName" },
                values: new object[] { "Todd Phillips", "War dogs" });
        }
    }
}
