using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    ChefId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChefNaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.ChefId);
                });

            migrationBuilder.CreateTable(
                name: "MenuGangs",
                columns: table => new
                {
                    MenuGangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGangName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGangs", x => x.MenuGangId);
                });

            migrationBuilder.CreateTable(
                name: "Temperatuurs",
                columns: table => new
                {
                    TemperatuurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITemperatuurName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatuurs", x => x.TemperatuurId);
                });

            migrationBuilder.CreateTable(
                name: "TypeGerechts",
                columns: table => new
                {
                    TypeGerechtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeGerechtName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeGerechts", x => x.TypeGerechtId);
                });

            migrationBuilder.CreateTable(
                name: "Recepts",
                columns: table => new
                {
                    ReceptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afbeelding = table.Column<byte>(type: "tinyint", nullable: false),
                    MenuGangId = table.Column<int>(type: "int", nullable: false),
                    TemperatuurId = table.Column<int>(type: "int", nullable: false),
                    TypeGerechtId = table.Column<int>(type: "int", nullable: false),
                    AanmaakDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepts", x => x.ReceptId);
                    table.ForeignKey(
                        name: "FK_Recepts_MenuGangs_MenuGangId",
                        column: x => x.MenuGangId,
                        principalTable: "MenuGangs",
                        principalColumn: "MenuGangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recepts_Temperatuurs_TemperatuurId",
                        column: x => x.TemperatuurId,
                        principalTable: "Temperatuurs",
                        principalColumn: "TemperatuurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recepts_TypeGerechts_TypeGerechtId",
                        column: x => x.TypeGerechtId,
                        principalTable: "TypeGerechts",
                        principalColumn: "TypeGerechtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Afbeeldings",
                columns: table => new
                {
                    AfbeeldingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AfbeeldingNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afbeeldings", x => x.AfbeeldingId);
                    table.ForeignKey(
                        name: "FK_Afbeeldings_Recepts_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recepts",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eenheid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hoeveelheid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recepts_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recepts",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afbeeldings_ReceptId",
                table: "Afbeeldings",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ReceptId",
                table: "Ingredients",
                column: "ReceptId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepts_MenuGangId",
                table: "Recepts",
                column: "MenuGangId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepts_TemperatuurId",
                table: "Recepts",
                column: "TemperatuurId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepts_TypeGerechtId",
                table: "Recepts",
                column: "TypeGerechtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afbeeldings");

            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recepts");

            migrationBuilder.DropTable(
                name: "MenuGangs");

            migrationBuilder.DropTable(
                name: "Temperatuurs");

            migrationBuilder.DropTable(
                name: "TypeGerechts");
        }
    }
}
