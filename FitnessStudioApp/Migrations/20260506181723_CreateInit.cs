using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessStudioApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_TrainingSession_TrainingSessionId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingSession_Trainers_TrainerId",
                table: "TrainingSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingSession",
                table: "TrainingSession");

            migrationBuilder.RenameTable(
                name: "TrainingSession",
                newName: "TrainingSessions");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingSession_TrainerId",
                table: "TrainingSessions",
                newName: "IX_TrainingSessions_TrainerId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Memberships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Memberships",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingSessions",
                table: "TrainingSessions",
                column: "TrainingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings",
                column: "TrainingSessionId",
                principalTable: "TrainingSessions",
                principalColumn: "TrainingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingSessions_Trainers_TrainerId",
                table: "TrainingSessions",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_TrainingSessions_TrainingSessionId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingSessions_Trainers_TrainerId",
                table: "TrainingSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingSessions",
                table: "TrainingSessions");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "TrainingSessions",
                newName: "TrainingSession");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingSessions_TrainerId",
                table: "TrainingSession",
                newName: "IX_TrainingSession_TrainerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingSession",
                table: "TrainingSession",
                column: "TrainingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_TrainingSession_TrainingSessionId",
                table: "Bookings",
                column: "TrainingSessionId",
                principalTable: "TrainingSession",
                principalColumn: "TrainingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingSession_Trainers_TrainerId",
                table: "TrainingSession",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
