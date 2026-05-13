using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessStudioApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyFat",
                table: "Progresses");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Progresses");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Progresses",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Calories",
                table: "Progresses",
                newName: "Height");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Progresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Clients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Progresses");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Progresses",
                newName: "Calories");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Progresses",
                newName: "Notes");

            migrationBuilder.AddColumn<double>(
                name: "BodyFat",
                table: "Progresses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Progresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
