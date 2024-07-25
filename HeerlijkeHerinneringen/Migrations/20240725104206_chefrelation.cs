using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class chefrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chefs_Recepts_ReceptId",
                table: "Chefs");

            migrationBuilder.DropIndex(
                name: "IX_Chefs_ReceptId",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "ReceptId",
                table: "Chefs");

            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "Recepts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recepts_ChefId",
                table: "Recepts",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recepts_Chefs_ChefId",
                table: "Recepts",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recepts_Chefs_ChefId",
                table: "Recepts");

            migrationBuilder.DropIndex(
                name: "IX_Recepts_ChefId",
                table: "Recepts");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Recepts");

            migrationBuilder.AddColumn<int>(
                name: "ReceptId",
                table: "Chefs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_ReceptId",
                table: "Chefs",
                column: "ReceptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chefs_Recepts_ReceptId",
                table: "Chefs",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
