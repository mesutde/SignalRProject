using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig_update_basket2_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_MoneyCases_MoneyCaseID",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_MoneyCaseID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "MoneyCaseID",
                table: "Baskets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoneyCaseID",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_MoneyCaseID",
                table: "Baskets",
                column: "MoneyCaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_MoneyCases_MoneyCaseID",
                table: "Baskets",
                column: "MoneyCaseID",
                principalTable: "MoneyCases",
                principalColumn: "MoneyCaseID");
        }
    }
}