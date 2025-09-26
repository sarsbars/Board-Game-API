using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Board_Game_API.Migrations
{
    /// <inheritdoc />
    public partial class participantcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayParticipants_Users_UserID",
                table: "PlayParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayParticipants_Users_UserID",
                table: "PlayParticipants",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayParticipants_Users_UserID",
                table: "PlayParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayParticipants_Users_UserID",
                table: "PlayParticipants",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
