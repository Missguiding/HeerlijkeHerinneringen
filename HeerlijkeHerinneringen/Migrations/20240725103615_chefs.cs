using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class chefs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
