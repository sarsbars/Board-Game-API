using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Board_Game_API.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "CollectionID", "UserID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "AgeMinimum", "AverageSession", "Complexity", "GameGenre", "GameName", "IsCardGame", "IsCompetitive", "MaxPlayers", "MinPlayers" },
                values: new object[,]
                {
                    { 1, 8, 20, 1, "Party", "Flip 7", true, true, 7, 2 },
                    { 2, 8, 10, 1, "Party", "Fluxx", true, true, 6, 2 },
                    { 3, 10, 15, 1, "Party", "Fluxx Marvel", true, true, 6, 2 },
                    { 4, 14, 15, 2, "Party", "One Night Revolution", true, true, 10, 4 },
                    { 5, 13, 30, 2, "Party", "The Resistance", true, true, 10, 5 },
                    { 6, 17, 45, 3, "Party", "Secret Hitler", true, true, 10, 5 },
                    { 7, 10, 60, 2, "Family", "Flamecraft", false, true, 5, 2 },
                    { 8, 13, 45, 2, "Family", "Bohnanza", true, true, 7, 2 },
                    { 9, 8, 20, 1, "Party", "Just One", true, true, 7, 3 },
                    { 10, 10, 30, 2, "Party", "So Clover", true, true, 8, 3 },
                    { 11, 10, 30, 1, "Party", "Herd Mentality", false, true, 8, 4 },
                    { 12, 14, 30, 3, "Strategy", "Dice Throne", false, true, 6, 2 },
                    { 13, 12, 60, 3, "Party", "Betrayal at House on the Hill", false, true, 6, 3 },
                    { 14, 10, 90, 3, "Strategy", "Catan", false, true, 4, 3 },
                    { 15, 8, 45, 2, "Family", "Ticket to Ride", false, true, 5, 2 },
                    { 16, 10, 60, 3, "Strategy", "Wingspan", false, true, 5, 1 },
                    { 17, 8, 60, 3, "Cooperative", "Pandemic", false, false, 4, 2 },
                    { 18, 14, 15, 2, "Party", "Codenames", true, true, 8, 2 },
                    { 19, 14, 90, 4, "Strategy", "Scythe", false, true, 5, 1 },
                    { 20, 14, 120, 5, "Strategy", "Gloomhaven", false, false, 4, 1 },
                    { 21, 12, 120, 4, "Strategy", "Terraforming Mars", false, true, 5, 1 },
                    { 22, 8, 30, 2, "Abstract", "Azul", false, true, 4, 2 },
                    { 23, 7, 45, 2, "Family", "Carcassonne", false, true, 5, 2 },
                    { 24, 10, 30, 3, "Strategy", "7 Wonders", true, true, 7, 3 },
                    { 25, 14, 30, 3, "Strategy", "Dominion", true, true, 4, 2 },
                    { 26, 10, 30, 2, "Strategy", "Splendor", false, true, 4, 2 },
                    { 27, 10, 90, 3, "Strategy", "Stone Age", false, true, 4, 2 },
                    { 28, 12, 120, 4, "Strategy", "Power Grid", false, true, 6, 2 },
                    { 29, 12, 120, 4, "Strategy", "Agricola", false, true, 4, 1 },
                    { 30, 12, 120, 4, "Strategy", "Le Havre", false, true, 5, 1 },
                    { 31, 10, 100, 3, "Strategy", "Concordia", false, true, 5, 2 },
                    { 32, 10, 60, 3, "Strategy", "Istanbul", false, true, 5, 2 },
                    { 33, 12, 90, 3, "Strategy", "The Voyages of Marco Polo", false, true, 4, 2 },
                    { 34, 12, 60, 3, "Strategy", "Lords of Waterdeep", false, true, 6, 2 },
                    { 35, 10, 90, 3, "Strategy", "Castles of Mad King Ludwig", false, true, 4, 1 },
                    { 36, 10, 45, 2, "Abstract", "Sagrada", false, true, 4, 1 },
                    { 37, 13, 80, 3, "Strategy", "Everdell", false, true, 4, 1 },
                    { 38, 10, 60, 3, "Strategy", "Wingspan: Oceania", false, true, 5, 1 },
                    { 39, 12, 90, 3, "Cooperative", "Fate of the Fellowship", false, false, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CollectionID", "Email", "FirstName", "JoinDate", "LastName", "Username" },
                values: new object[,]
                {
                    { 1, null, "sarah.m@boardgames.com", "Sarah", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", "smitchell" },
                    { 2, null, "cody.w@boardgames.com", "Cody", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wallbridge", "cwallbridge" },
                    { 3, null, "connor.h@boardgames.com", "Connor", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", "chall" },
                    { 4, null, "ashedzi.s@boardgames.com", "Ashedzi", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solomon", "asolomon" },
                    { 5, null, "ayomide.b@boardgames.com", "Ayomide", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boye-Ogundiya", "aboye" },
                    { 6, null, "navjot.k@boardgames.com", "Navjot", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaur", "nkaur" },
                    { 7, null, "xiyu.z@boardgames.com", "Xiyu", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zhou", "xzhou" },
                    { 8, null, "haodi.h@boardgames.com", "Haodi", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hua", "hhua" },
                    { 9, null, "jasper.h@boardgames.com", "Jasper", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", "jhall" },
                    { 10, null, "ruby.m@boardgames.com", "Ruby", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", "rmitchell" },
                    { 11, null, "bagel.m@boardgames.com", "Bagel", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", "bmitchell" },
                    { 12, null, "charlie.m@boardgames.com", "Charlie", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", "cmitchell" },
                    { 13, null, "creamcheese.m@boardgames.com", "Cream-Cheese", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", "ccmitchell" },
                    { 14, null, "brock.z@boardgames.com", "Brock", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zimmerman", "bzimmerman" }
                });

            migrationBuilder.InsertData(
                table: "CollectionGames",
                columns: new[] { "CollectionGameID", "CollectionID", "Condition", "GameID", "PersonalRating" },
                values: new object[,]
                {
                    { 1, 1, "New", 1, 9 },
                    { 2, 1, "Used", 2, 8 },
                    { 3, 1, "New", 3, 10 },
                    { 4, 1, "Used", 4, 7 },
                    { 5, 2, "New", 5, 9 },
                    { 6, 2, "Used", 6, 8 },
                    { 7, 2, "New", 7, 10 },
                    { 8, 2, "Used", 8, 7 },
                    { 9, 3, "New", 9, 9 },
                    { 10, 3, "Used", 10, 8 },
                    { 11, 3, "New", 11, 10 },
                    { 12, 3, "Used", 12, 7 },
                    { 13, 4, "New", 13, 9 },
                    { 14, 4, "Used", 14, 8 },
                    { 15, 4, "New", 15, 10 },
                    { 16, 5, "New", 16, 9 },
                    { 17, 5, "Used", 17, 8 },
                    { 18, 5, "New", 18, 10 },
                    { 19, 5, "Used", 19, 7 },
                    { 20, 6, "New", 20, 9 },
                    { 21, 6, "Used", 21, 8 },
                    { 22, 6, "New", 22, 10 },
                    { 23, 6, "Used", 23, 7 },
                    { 24, 7, "New", 24, 9 },
                    { 25, 7, "Used", 25, 8 },
                    { 26, 7, "New", 26, 10 },
                    { 27, 8, "New", 27, 9 },
                    { 28, 8, "Used", 28, 8 },
                    { 29, 8, "New", 29, 10 },
                    { 30, 9, "New", 30, 9 },
                    { 31, 9, "Used", 31, 8 },
                    { 32, 9, "New", 32, 10 },
                    { 33, 10, "New", 33, 9 },
                    { 34, 10, "Used", 34, 8 },
                    { 35, 10, "New", 35, 10 },
                    { 36, 11, "New", 1, 9 },
                    { 37, 11, "Used", 2, 8 },
                    { 38, 11, "New", 3, 10 },
                    { 39, 12, "New", 4, 9 },
                    { 40, 12, "Used", 5, 8 },
                    { 41, 12, "New", 6, 10 },
                    { 42, 13, "New", 7, 9 },
                    { 43, 13, "Used", 8, 8 },
                    { 44, 13, "New", 9, 10 },
                    { 45, 14, "New", 10, 9 },
                    { 46, 14, "Used", 11, 8 },
                    { 47, 14, "New", 12, 10 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionID", "GameID", "LengthOfTime", "PlayDate", "Summary", "WinnerID" },
                values: new object[,]
                {
                    { 1, 1, 25, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fun flip 7 game night", 1 },
                    { 2, 2, 15, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quick fluxx round", 2 },
                    { 3, 3, 20, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel fluxx chaos", 1 },
                    { 4, 5, 35, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resistance betrayal", 3 },
                    { 5, 6, 50, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secret Hitler intrigue", 2 },
                    { 6, 7, 65, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flamecraft dragons", 4 },
                    { 7, 9, 25, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Just One guesses", 1 },
                    { 8, 10, 35, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "So Clover words", 3 },
                    { 9, 11, 35, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herd Mentality herd", 5 },
                    { 10, 12, 35, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dice Throne battles", 4 },
                    { 11, 13, 70, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betrayal haunt", 6 },
                    { 12, 14, 95, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catan trades", 4 },
                    { 13, 15, 50, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ticket to Ride routes", 5 },
                    { 14, 16, 65, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wingspan birds", 7 },
                    { 15, 17, 65, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pandemic cure", 5 },
                    { 16, 18, 20, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Codenames words", 6 },
                    { 17, 19, 95, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scythe mechs", 8 },
                    { 18, 20, 125, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gloomhaven quests", 6 },
                    { 19, 21, 125, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terraforming Mars", 7 },
                    { 20, 22, 35, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azul tiles", 9 },
                    { 21, 23, 50, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carcassonne tiles", 7 },
                    { 22, 24, 35, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 Wonders wonders", 8 },
                    { 23, 25, 35, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominion decks", 10 },
                    { 24, 26, 35, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Splendor gems", 8 },
                    { 25, 27, 95, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stone Age tools", 9 },
                    { 26, 28, 125, new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Power Grid power", 11 },
                    { 27, 29, 125, new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agricola farms", 9 },
                    { 28, 30, 125, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Le Havre ports", 10 },
                    { 29, 31, 105, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concordia trade", 12 },
                    { 30, 32, 65, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Istanbul markets", 10 },
                    { 31, 33, 95, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco Polo voyages", 11 },
                    { 32, 34, 65, new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waterdeep lords", 13 },
                    { 33, 35, 95, new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad King Ludwig castles", 11 },
                    { 34, 36, 50, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagrada stained glass", 12 },
                    { 35, 37, 85, new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everdell critters", 14 },
                    { 36, 38, 65, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wingspan Oceania birds", 12 },
                    { 37, 14, 95, new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catan trades", 13 },
                    { 38, 15, 50, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ticket to Ride routes", 1 },
                    { 39, 16, 65, new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wingspan birds", 13 },
                    { 40, 17, 65, new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pandemic cure", 14 },
                    { 41, 18, 20, new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Codenames words", 2 },
                    { 42, 19, 95, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scythe mechs", 14 }
                });

            migrationBuilder.InsertData(
                table: "PlayParticipants",
                columns: new[] { "ParticipantID", "IsWinner", "Score", "SessionID", "UserID" },
                values: new object[,]
                {
                    { 1, true, 12, 1, 1 },
                    { 2, false, 9, 1, 2 },
                    { 3, false, 11, 1, 3 },
                    { 4, true, 14, 2, 2 },
                    { 5, false, 10, 2, 1 },
                    { 6, true, 13, 3, 1 },
                    { 7, false, 8, 3, 3 },
                    { 8, false, 12, 3, 4 },
                    { 9, true, 15, 4, 3 },
                    { 10, false, 11, 4, 2 },
                    { 11, false, 13, 4, 5 },
                    { 12, false, 10, 4, 1 },
                    { 13, true, 14, 5, 2 },
                    { 14, false, 9, 5, 3 },
                    { 15, false, 12, 5, 6 },
                    { 16, true, 11, 6, 4 },
                    { 17, false, 13, 6, 2 },
                    { 18, false, 10, 6, 7 },
                    { 19, true, 12, 7, 1 },
                    { 20, false, 8, 7, 3 },
                    { 21, false, 11, 7, 5 },
                    { 22, true, 13, 8, 3 },
                    { 23, false, 10, 8, 1 },
                    { 24, false, 12, 8, 8 },
                    { 25, true, 14, 9, 5 },
                    { 26, false, 9, 9, 3 },
                    { 27, false, 11, 9, 9 },
                    { 28, true, 15, 10, 4 },
                    { 29, false, 12, 10, 6 },
                    { 30, false, 13, 10, 2 },
                    { 31, true, 12, 11, 6 },
                    { 32, false, 11, 11, 4 },
                    { 33, false, 14, 11, 10 },
                    { 34, true, 13, 12, 4 },
                    { 35, false, 10, 12, 8 },
                    { 36, false, 12, 12, 12 },
                    { 37, true, 14, 13, 5 },
                    { 38, false, 9, 13, 7 },
                    { 39, false, 11, 13, 1 },
                    { 40, true, 15, 14, 5 },
                    { 41, false, 12, 14, 9 },
                    { 42, false, 13, 14, 13 },
                    { 43, true, 12, 15, 5 },
                    { 44, false, 10, 15, 11 },
                    { 45, false, 11, 15, 14 },
                    { 46, true, 13, 16, 6 },
                    { 47, false, 8, 16, 2 },
                    { 48, false, 12, 16, 4 },
                    { 49, true, 14, 17, 8 },
                    { 50, false, 11, 17, 6 },
                    { 51, false, 13, 17, 10 },
                    { 52, true, 15, 18, 6 },
                    { 53, false, 12, 18, 12 },
                    { 54, false, 14, 18, 14 },
                    { 55, true, 12, 19, 7 },
                    { 56, false, 9, 19, 1 },
                    { 57, false, 11, 19, 3 },
                    { 58, true, 13, 20, 9 },
                    { 59, false, 10, 20, 7 },
                    { 60, false, 12, 20, 11 },
                    { 61, true, 14, 21, 7 },
                    { 62, false, 11, 21, 13 },
                    { 63, false, 13, 21, 2 },
                    { 64, true, 15, 22, 8 },
                    { 65, false, 12, 22, 4 },
                    { 66, false, 14, 22, 6 },
                    { 67, true, 12, 23, 10 },
                    { 68, false, 9, 23, 8 },
                    { 69, false, 11, 23, 12 },
                    { 70, true, 13, 24, 8 },
                    { 71, false, 10, 24, 14 },
                    { 72, false, 12, 24, 1 },
                    { 73, true, 14, 25, 9 },
                    { 74, false, 11, 25, 5 },
                    { 75, false, 13, 25, 7 },
                    { 76, true, 15, 26, 11 },
                    { 77, false, 12, 26, 9 },
                    { 78, false, 14, 26, 13 },
                    { 79, true, 12, 27, 9 },
                    { 80, false, 9, 27, 1 },
                    { 81, false, 11, 27, 3 },
                    { 82, true, 13, 28, 10 },
                    { 83, false, 10, 28, 2 },
                    { 84, false, 12, 28, 4 },
                    { 85, true, 14, 29, 12 },
                    { 86, false, 11, 29, 10 },
                    { 87, false, 13, 29, 14 },
                    { 88, true, 15, 30, 10 },
                    { 89, false, 12, 30, 6 },
                    { 90, false, 14, 30, 8 },
                    { 91, true, 12, 31, 11 },
                    { 92, false, 9, 31, 7 },
                    { 93, false, 11, 31, 9 },
                    { 94, true, 13, 32, 13 },
                    { 95, false, 10, 32, 11 },
                    { 96, false, 12, 32, 1 },
                    { 97, true, 14, 33, 11 },
                    { 98, false, 11, 33, 3 },
                    { 99, false, 13, 33, 5 },
                    { 100, true, 15, 34, 12 },
                    { 101, false, 12, 34, 8 },
                    { 102, false, 14, 34, 10 },
                    { 103, true, 12, 35, 14 },
                    { 104, false, 9, 35, 12 },
                    { 105, false, 11, 35, 2 },
                    { 106, true, 13, 36, 12 },
                    { 107, false, 10, 36, 4 },
                    { 108, false, 12, 36, 6 },
                    { 109, true, 14, 37, 13 },
                    { 110, false, 11, 37, 9 },
                    { 111, false, 13, 37, 11 },
                    { 112, true, 15, 38, 1 },
                    { 113, false, 12, 38, 13 },
                    { 114, false, 14, 38, 7 },
                    { 115, true, 12, 39, 13 },
                    { 116, false, 9, 39, 5 },
                    { 117, false, 11, 39, 3 },
                    { 118, true, 13, 40, 14 },
                    { 119, false, 10, 40, 10 },
                    { 120, false, 12, 40, 12 },
                    { 121, true, 14, 41, 2 },
                    { 122, false, 11, 41, 14 },
                    { 123, false, 13, 41, 6 },
                    { 124, true, 15, 42, 14 },
                    { 125, false, 12, 42, 12 },
                    { 126, false, 14, 42, 13 },
                    { 127, false, 11, 42, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CollectionGames",
                keyColumn: "CollectionGameID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PlayParticipants",
                keyColumn: "ParticipantID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "CollectionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 14);
        }
    }
}
