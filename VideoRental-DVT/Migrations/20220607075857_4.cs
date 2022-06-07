using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental_DVT.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "CustomerName" },
                values: new object[] { 1, 21, "Dirk" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "RentId", "ReturnDate" },
                values: new object[] { 1, new DateTime(2022, 7, 5, 9, 58, 56, 940, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "RentId", "ReturnDate" },
                values: new object[] { 2, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Director", "Price", "RentId", "Rented", "RentedToCustomerId", "ReturnDate", "VideoName" },
                values: new object[,]
                {
                    { 3, "David", 15.0, 3, true, null, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5316), "Goodplace" },
                    { 4, "Bob Holand", 5.0, 4, true, null, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5321), "HappyGilmore" },
                    { 5, "Keenen Ivory Wayans", 9.9900000000000002, 5, true, null, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5324), "White chicks" },
                    { 6, "Todd Phillips", 8.0, 6, true, null, new DateTime(2022, 7, 5, 9, 58, 56, 942, DateTimeKind.Local).AddTicks(5327), "War dogs" },
                    { 7, "Todd Phillips", 13.49, null, false, null, null, "War dogs" },
                    { 8, "Greg Mottola", 8.0, null, false, null, null, "Superbad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "RentId", "ReturnDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "RentId", "ReturnDate" },
                values: new object[] { null, null });
        }
    }
}
