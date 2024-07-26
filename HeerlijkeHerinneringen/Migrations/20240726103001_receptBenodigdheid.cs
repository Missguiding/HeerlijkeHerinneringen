using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class receptBenodigdheid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Benodigdheids_Recepts_ReceptId",
                table: "Benodigdheids");

            migrationBuilder.DropIndex(
                name: "IX_Benodigdheids_ReceptId",
                table: "Benodigdheids");

            migrationBuilder.DropColumn(
                name: "ReceptId",
                table: "Benodigdheids");

            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "Benodigdheids",
                newName: "BenodigdheidNaam");

            migrationBuilder.CreateTable(
                name: "ReceptBenodigdheids",
                columns: table => new
                {
                    ReceptId = table.Column<int>(type: "int", nullable: false),
                    BenodigdheidId = table.Column<int>(type: "int", nullable: false),
                    Hoeveelheid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptBenodigdheids", x => new { x.ReceptId, x.BenodigdheidId });
                    table.ForeignKey(
                        name: "FK_ReceptBenodigdheids_Benodigdheids_BenodigdheidId",
                        column: x => x.BenodigdheidId,
                        principalTable: "Benodigdheids",
                        principalColumn: "BenodigdheidId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptBenodigdheids_Recepts_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recepts",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptBenodigdheids_BenodigdheidId",
                table: "ReceptBenodigdheids",
                column: "BenodigdheidId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptBenodigdheids");

            migrationBuilder.RenameColumn(
                name: "BenodigdheidNaam",
                table: "Benodigdheids",
                newName: "Naam");

            migrationBuilder.AddColumn<int>(
                name: "ReceptId",
                table: "Benodigdheids",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Benodigdheids_ReceptId",
                table: "Benodigdheids",
                column: "ReceptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Benodigdheids_Recepts_ReceptId",
                table: "Benodigdheids",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
