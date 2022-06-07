using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental_DVT.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Age",
                value: 33);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "CustomerName" },
                values: new object[,]
                {
                    { 2, 25, "Jeff" },
                    { 3, 18, "Shara" },
                    { 4, 21, "Amber" }
                });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "ReturnDate",
                value: new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "ReturnDate",
                value: new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "ReturnDate",
                value: new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "ReturnDate",
                value: new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "ReturnDate",
                value: new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "ReturnDate",
                value: new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "Price",
                value: 9.8000000000000007);

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Director", "Price", "RentId", "Rented", "RentedToCustomerId", "ReturnDate", "VideoName" },
                values: new object[,]
                {
                    { 9, "Robert Luketic", 12.1, 7, true, null, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "21" },
                    { 10, "Phil Lord", 14.5, null, false, null, null, "21 Jumpstreet" },
                    { 11, "Lou Adler", 20.0, 8, true, null, null, "Up In Smoke" },
                    { 12, "Todd Strauss-Schulson", 8.0, 9, true, null, null, "A Very Harold & Kumar Christmas" },
                    { 13, "Martin Scorsese", 8.0, null, false, null, null, "The wolf of wallstreet" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Age",
                value: 21);

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
                column: "ReturnDate",
                value: new DateTime(2022, 7, 5, 10, 25, 58, 316, DateTimeKind.Local).AddTicks(9137));

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
                keyValue: 8,
                column: "Price",
                value: 8.0);
        }
    }
}
