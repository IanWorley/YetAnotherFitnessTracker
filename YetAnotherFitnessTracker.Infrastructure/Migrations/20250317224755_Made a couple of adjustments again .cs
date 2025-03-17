using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YetAnotherFitnessTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Madeacoupleofadjustmentsagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_User_UserId",
                table: "Goal");

            migrationBuilder.DropIndex(
                name: "IX_Goal_UserId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "isCompleted",
                table: "Goal");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goal",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "GoalStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GoalId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalStatus_Goal_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GoalStatus_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoalStatus_GoalId",
                table: "GoalStatus",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalStatus_UserId",
                table: "GoalStatus",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoalStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Goal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Goal",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCompleted",
                table: "Goal",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Goal_UserId",
                table: "Goal",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_User_UserId",
                table: "Goal",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
