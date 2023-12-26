using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class finalupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Offers_OfferId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_OfferId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Meals");

            migrationBuilder.CreateTable(
                name: "OrderExtra",
                columns: table => new
                {
                    OrderExtraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderExtra", x => x.OrderExtraId);
                    table.ForeignKey(
                        name: "FK_OrderExtra_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderExtra_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderOffer",
                columns: table => new
                {
                    OrderOfferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOffer", x => x.OrderOfferId);
                    table.ForeignKey(
                        name: "FK_OrderOffer_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderOffer_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderExtra_ExtraId",
                table: "OrderExtra",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderExtra_OrderId",
                table: "OrderExtra",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffer_OfferId",
                table: "OrderOffer",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffer_OrderId",
                table: "OrderOffer",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderExtra");

            migrationBuilder.DropTable(
                name: "OrderOffer");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meals_OfferId",
                table: "Meals",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Offers_OfferId",
                table: "Meals",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }
    }
}
