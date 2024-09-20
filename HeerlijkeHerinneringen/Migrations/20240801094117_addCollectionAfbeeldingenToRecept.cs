using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class addCollectionAfbeeldingenToRecept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Afbeelding",
                table: "Recepts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Afbeelding",
                table: "Recepts",
                type: "tinyint",
                nullable: true);
        }
    }
}
