using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    /// <inheritdoc />
    public partial class nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ITemperatuurName",
                table: "Temperatuurs",
                newName: "TemperatuurName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDatum",
                table: "Recepts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Beschrijving",
                table: "Recepts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte>(
                name: "Afbeelding",
                table: "Recepts",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AanmaakDatum",
                table: "Recepts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "AfbeeldingNaam",
                table: "Afbeeldings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AfbeeldingUrl",
                table: "Afbeeldings",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AfbeeldingUrl",
                table: "Afbeeldings");

            migrationBuilder.RenameColumn(
                name: "TemperatuurName",
                table: "Temperatuurs",
                newName: "ITemperatuurName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDatum",
                table: "Recepts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Beschrijving",
                table: "Recepts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Afbeelding",
                table: "Recepts",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AanmaakDatum",
                table: "Recepts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AfbeeldingNaam",
                table: "Afbeeldings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
