using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessStudioApp.Migrations
{
    /// <inheritdoc />
    public partial class NewTrainerFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Trainers");
        }
    }
}
