using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class DbContextUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Benodigdheid_Recepts_ReceptId",
                table: "Benodigdheid");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptStap_Recepts_ReceptId",
                table: "ReceptStap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceptStap",
                table: "ReceptStap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Benodigdheid",
                table: "Benodigdheid");

            migrationBuilder.RenameTable(
                name: "ReceptStap",
                newName: "ReceptStaps");

            migrationBuilder.RenameTable(
                name: "Benodigdheid",
                newName: "Benodigdheids");

            migrationBuilder.RenameIndex(
                name: "IX_ReceptStap_ReceptId",
                table: "ReceptStaps",
                newName: "IX_ReceptStaps_ReceptId");

            migrationBuilder.RenameIndex(
                name: "IX_Benodigdheid_ReceptId",
                table: "Benodigdheids",
                newName: "IX_Benodigdheids_ReceptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceptStaps",
                table: "ReceptStaps",
                column: "ReceptStapId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benodigdheids",
                table: "Benodigdheids",
                column: "BenodigdheidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Benodigdheids_Recepts_ReceptId",
                table: "Benodigdheids",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptStaps_Recepts_ReceptId",
                table: "ReceptStaps",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Benodigdheids_Recepts_ReceptId",
                table: "Benodigdheids");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceptStaps_Recepts_ReceptId",
                table: "ReceptStaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceptStaps",
                table: "ReceptStaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Benodigdheids",
                table: "Benodigdheids");

            migrationBuilder.RenameTable(
                name: "ReceptStaps",
                newName: "ReceptStap");

            migrationBuilder.RenameTable(
                name: "Benodigdheids",
                newName: "Benodigdheid");

            migrationBuilder.RenameIndex(
                name: "IX_ReceptStaps_ReceptId",
                table: "ReceptStap",
                newName: "IX_ReceptStap_ReceptId");

            migrationBuilder.RenameIndex(
                name: "IX_Benodigdheids_ReceptId",
                table: "Benodigdheid",
                newName: "IX_Benodigdheid_ReceptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceptStap",
                table: "ReceptStap",
                column: "ReceptStapId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benodigdheid",
                table: "Benodigdheid",
                column: "BenodigdheidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Benodigdheid_Recepts_ReceptId",
                table: "Benodigdheid",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceptStap_Recepts_ReceptId",
                table: "ReceptStap",
                column: "ReceptId",
                principalTable: "Recepts",
                principalColumn: "ReceptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
