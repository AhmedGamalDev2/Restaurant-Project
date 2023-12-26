using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class fordb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderExtra_Extras_ExtraId",
                table: "OrderExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderExtra_Orders_OrderId",
                table: "OrderExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffer_Offers_OfferId",
                table: "OrderOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffer_Orders_OrderId",
                table: "OrderOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderOffer",
                table: "OrderOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderExtra",
                table: "OrderExtra");

            migrationBuilder.RenameTable(
                name: "OrderOffer",
                newName: "OrderOffers");

            migrationBuilder.RenameTable(
                name: "OrderExtra",
                newName: "OrderExtras");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOffer_OrderId",
                table: "OrderOffers",
                newName: "IX_OrderOffers_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOffer_OfferId",
                table: "OrderOffers",
                newName: "IX_OrderOffers_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderExtra_OrderId",
                table: "OrderExtras",
                newName: "IX_OrderExtras_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderExtra_ExtraId",
                table: "OrderExtras",
                newName: "IX_OrderExtras_ExtraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderOffers",
                table: "OrderOffers",
                column: "OrderOfferId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderExtras",
                table: "OrderExtras",
                column: "OrderExtraId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderExtras_Extras_ExtraId",
                table: "OrderExtras",
                column: "ExtraId",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderExtras_Orders_OrderId",
                table: "OrderExtras",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_Offers_OfferId",
                table: "OrderOffers",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_Orders_OrderId",
                table: "OrderOffers",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderExtras_Extras_ExtraId",
                table: "OrderExtras");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderExtras_Orders_OrderId",
                table: "OrderExtras");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_Offers_OfferId",
                table: "OrderOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_Orders_OrderId",
                table: "OrderOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderOffers",
                table: "OrderOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderExtras",
                table: "OrderExtras");

            migrationBuilder.RenameTable(
                name: "OrderOffers",
                newName: "OrderOffer");

            migrationBuilder.RenameTable(
                name: "OrderExtras",
                newName: "OrderExtra");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOffers_OrderId",
                table: "OrderOffer",
                newName: "IX_OrderOffer_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderOffers_OfferId",
                table: "OrderOffer",
                newName: "IX_OrderOffer_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderExtras_OrderId",
                table: "OrderExtra",
                newName: "IX_OrderExtra_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderExtras_ExtraId",
                table: "OrderExtra",
                newName: "IX_OrderExtra_ExtraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderOffer",
                table: "OrderOffer",
                column: "OrderOfferId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderExtra",
                table: "OrderExtra",
                column: "OrderExtraId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderExtra_Extras_ExtraId",
                table: "OrderExtra",
                column: "ExtraId",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderExtra_Orders_OrderId",
                table: "OrderExtra",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffer_Offers_OfferId",
                table: "OrderOffer",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffer_Orders_OrderId",
                table: "OrderOffer",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
