using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRental_DVT.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rented",
                table: "Videos",
                newName: "Rented");

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Director", "Price", "RentId", "Rented", "RentedToCustomerId", "ReturnDate", "VideoName" },
                values: new object[] { 1, "Bob", 22.0, null, true, null, null, "jumanji" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Director", "Price", "RentId", "Rented", "RentedToCustomerId", "ReturnDate", "VideoName" },
                values: new object[] { 2, "David", 22.0, null, true, null, null, "WalkingDead" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Rented",
                table: "Videos",
                newName: "rented");
        }
    }
}
