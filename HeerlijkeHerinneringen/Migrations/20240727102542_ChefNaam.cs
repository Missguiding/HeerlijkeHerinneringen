using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class ChefNaam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChefNaam",
                table: "Chefs",
                newName: "ChefVoorNaam");

            migrationBuilder.AddColumn<string>(
                name: "ChefFamilieNaam",
                table: "Chefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefFamilieNaam",
                table: "Chefs");

            migrationBuilder.RenameColumn(
                name: "ChefVoorNaam",
                table: "Chefs",
                newName: "ChefNaam");
        }
    }
}
