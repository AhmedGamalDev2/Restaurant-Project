using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class offernew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartOffer",
                table: "Offers",
                newName: "startdate");

            migrationBuilder.RenameColumn(
                name: "ExpireOffer",
                table: "Offers",
                newName: "enddate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startdate",
                table: "Offers",
                newName: "StartOffer");

            migrationBuilder.RenameColumn(
                name: "enddate",
                table: "Offers",
                newName: "ExpireOffer");
        }
    }
}
