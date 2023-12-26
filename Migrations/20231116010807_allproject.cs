using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class allproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Meals_MealId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_MealId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Extras");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Extras",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Extras");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "Extras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Extras_MealId",
                table: "Extras",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Meals_MealId",
                table: "Extras",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
