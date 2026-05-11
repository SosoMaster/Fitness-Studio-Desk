using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessStudioApp.Migrations
{
    /// <inheritdoc />
    public partial class newMigrationCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Clients_ClientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Clients_ClientId",
                table: "Bookings",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings",
                column: "TrainingSessionId",
                principalTable: "TrainingSessions",
                principalColumn: "TrainingSessionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Clients_ClientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Clients_ClientId",
                table: "Bookings",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings",
                column: "TrainingSessionId",
                principalTable: "TrainingSessions",
                principalColumn: "TrainingSessionId");
        }
    }
}
