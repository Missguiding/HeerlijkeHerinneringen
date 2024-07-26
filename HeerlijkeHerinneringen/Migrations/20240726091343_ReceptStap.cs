using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class ReceptStap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beschrijving",
                table: "Recepts");

            migrationBuilder.CreateTable(
                name: "ReceptStap",
                columns: table => new
                {
                    ReceptStapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Volgorde = table.Column<int>(type: "int", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptStap", x => x.ReceptStapId);
                    table.ForeignKey(
                        name: "FK_ReceptStap_Recepts_ReceptId",
                        column: x => x.ReceptId,
                        principalTable: "Recepts",
                        principalColumn: "ReceptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptStap_ReceptId",
                table: "ReceptStap",
                column: "ReceptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptStap");

            migrationBuilder.AddColumn<string>(
                name: "Beschrijving",
                table: "Recepts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
