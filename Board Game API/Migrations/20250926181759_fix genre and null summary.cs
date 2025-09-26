using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Board_Game_API.Migrations
{
    /// <inheritdoc />
    public partial class fixgenreandnullsummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                UPDATE Games
                SET GameGenre =
                    CASE GameGenre
                        WHEN 'Strategy' THEN '0'
                        WHEN 'Family' THEN '1'
                        WHEN 'Party' THEN '2'
                        WHEN 'Abstract' THEN '3'
                        WHEN 'Cooperative' THEN '4'
                        WHEN 'DeckBuilding' THEN '5'
                        WHEN 'Eurogame' THEN '6'
                    END
                WHERE GameGenre IS NOT NULL
            ");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Sessions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "GameGenre",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 1,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 2,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 3,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 4,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 5,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 6,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 7,
                column: "GameGenre",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 8,
                column: "GameGenre",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 9,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 10,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 11,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 12,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 13,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 14,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 15,
                column: "GameGenre",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 16,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 17,
                column: "GameGenre",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 18,
                column: "GameGenre",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 19,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 20,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 21,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 22,
                column: "GameGenre",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 23,
                column: "GameGenre",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 24,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 25,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 26,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 27,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 28,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 29,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 30,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 31,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 32,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 33,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 34,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 35,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 36,
                column: "GameGenre",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 37,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 38,
                column: "GameGenre",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 39,
                column: "GameGenre",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Sessions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GameGenre",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 1,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 2,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 3,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 4,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 5,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 6,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 7,
                column: "GameGenre",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 8,
                column: "GameGenre",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 9,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 10,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 11,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 12,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 13,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 14,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 15,
                column: "GameGenre",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 16,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 17,
                column: "GameGenre",
                value: "Cooperative");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 18,
                column: "GameGenre",
                value: "Party");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 19,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 20,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 21,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 22,
                column: "GameGenre",
                value: "Abstract");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 23,
                column: "GameGenre",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 24,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 25,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 26,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 27,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 28,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 29,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 30,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 31,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 32,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 33,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 34,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 35,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 36,
                column: "GameGenre",
                value: "Abstract");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 37,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 38,
                column: "GameGenre",
                value: "Strategy");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 39,
                column: "GameGenre",
                value: "Cooperative");
        }
    }
}
