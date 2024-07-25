using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recepts_ReceptId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ReceptId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Eenheid",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Hoeveelheid",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ReceptId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "ReceptIngredients",
                columns: table => new
                {
                    ReceptId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Eenheid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hoeveelheid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptIngredients", x => new { x.ReceptId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_ReceptIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptIngredients_Recepts_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recepts",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptIngredients_IngredientId",
                table: "ReceptIngredients",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptIngredients");

            migrationBuilder.AddColumn<string>(
                name: "Eenheid",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hoeveelheid",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReceptId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ReceptId",
                table: "Ingredients",
                column: "ReceptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recepts_ReceptId",
                table: "Ingredients",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
