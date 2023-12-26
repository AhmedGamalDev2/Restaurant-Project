using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class roletry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "ed031580-7456-47e9-bdb1-e3d26d39fb6e", "admin", "ADMIN" },
                    { "2", "221460d6-3bb5-4f4b-8386-57c37120665c", "user", "USER" },
                    { "3", "b737e90f-53ff-4455-a7fb-1fba0d1d1463", "cashier", "CASHIER" },
                    { "4", "b9e9cf87-e970-4fe2-8676-019ba6dc185b", "delivery", "DELIVERY" }
                });
        }
    }
}
