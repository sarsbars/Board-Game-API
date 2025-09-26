using Board_Game_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Board_Game_API.Models { 

    public class BoardGameContext : DbContext {
        public BoardGameContext(DbContextOptions<BoardGameContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } 
        public DbSet<Collection> Collections { get; set; } 
        public DbSet<CollectionGame> CollectionGames { get; set; } 
        public DbSet<Game> Games { get; set; } 
        public DbSet<Session> Sessions { get; set; } 
        public DbSet<PlayParticipant> PlayParticipants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // User
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Collection)
                .WithOne(c => c.User)
                .HasForeignKey<User>(u => u.CollectionID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.CollectionID)
                .IsUnique();

            // Collection
            modelBuilder.Entity<Collection>()
                .HasKey(c => c.CollectionID);
            modelBuilder.Entity<Collection>()
                .HasIndex(c => c.UserID)
                .IsUnique();

            // CollectionGame
            modelBuilder.Entity<CollectionGame>()
                .HasKey(cg => cg.CollectionGameID);
            modelBuilder.Entity<CollectionGame>()
                .HasOne(cg => cg.Collection)
                .WithMany(c => c.CollectionGames)
                .HasForeignKey(cg => cg.CollectionID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CollectionGame>()
                .HasOne(cg => cg.Game)
                .WithMany(g => g.CollectionGames)
                .HasForeignKey(cg => cg.GameID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CollectionGame>()
                .Property(cg => cg.Condition)
                .HasMaxLength(30);
            modelBuilder.Entity<CollectionGame>()
                .Property(cg => cg.PersonalRating)
                .HasColumnType("int");

            // Game
            modelBuilder.Entity<Game>()
                .HasKey(g => g.GameID);
            modelBuilder.Entity<Game>()
                .Property(g => g.GameName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Game>()
                .Property(g => g.GameGenre)
                .HasConversion<int>();
            modelBuilder.Entity<Game>()
                .Property(g => g.Complexity)
                .HasColumnType("int");
            modelBuilder.Entity<Game>()
                .Property(g => g.AverageSession)
                .HasColumnType("int");
            modelBuilder.Entity<Game>()
                .Property(g => g.AgeMinimum)
                .HasColumnType("int");

            // Session
            modelBuilder.Entity<Session>()
                .HasKey(s => s.SessionID);
            modelBuilder.Entity<Session>()
                .HasOne(s => s.Game)
                .WithMany(g => g.Sessions)
                .HasForeignKey(s => s.GameID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Session>()
                .HasOne(s => s.Winner)
                .WithMany()
                .HasForeignKey(s => s.WinnerID)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Session>()
                .Property(s => s.Summary)
                .HasMaxLength(1000);
            modelBuilder.Entity<Session>()
                .Property(s => s.PlayDate)
                .IsRequired();

            // PlayParticipant
            modelBuilder.Entity<PlayParticipant>()
                .HasKey(p => p.ParticipantID);
            modelBuilder.Entity<PlayParticipant>()
                .HasOne(p => p.Session)
                .WithMany(s => s.PlayParticipants)
                .HasForeignKey(p => p.SessionID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PlayParticipant>()
                .HasOne(p => p.User)
                .WithMany(u => u.PlayParticipants)
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, Username = "smitchell", FirstName = "Sarah", LastName = "Mitchell", Email = "sarah.m@boardgames.com", JoinDate = DateTime.Parse("2025-01-15") },
                new User { UserID = 2, Username = "cwallbridge", FirstName = "Cody", LastName = "Wallbridge", Email = "cody.w@boardgames.com", JoinDate = DateTime.Parse("2025-01-20") },
                new User { UserID = 3, Username = "chall", FirstName = "Connor", LastName = "Hall", Email = "connor.h@boardgames.com", JoinDate = DateTime.Parse("2025-02-01") },
                new User { UserID = 4, Username = "asolomon", FirstName = "Ashedzi", LastName = "Solomon", Email = "ashedzi.s@boardgames.com", JoinDate = DateTime.Parse("2025-02-10") },
                new User { UserID = 5, Username = "aboye", FirstName = "Ayomide", LastName = "Boye-Ogundiya", Email = "ayomide.b@boardgames.com", JoinDate = DateTime.Parse("2025-02-15") },
                new User { UserID = 6, Username = "nkaur", FirstName = "Navjot", LastName = "Kaur", Email = "navjot.k@boardgames.com", JoinDate = DateTime.Parse("2025-03-01") },
                new User { UserID = 7, Username = "xzhou", FirstName = "Xiyu", LastName = "Zhou", Email = "xiyu.z@boardgames.com", JoinDate = DateTime.Parse("2025-03-05") },
                new User { UserID = 8, Username = "hhua", FirstName = "Haodi", LastName = "Hua", Email = "haodi.h@boardgames.com", JoinDate = DateTime.Parse("2025-03-10") },
                new User { UserID = 9, Username = "jhall", FirstName = "Jasper", LastName = "Hall", Email = "jasper.h@boardgames.com", JoinDate = DateTime.Parse("2025-03-15") },
                new User { UserID = 10, Username = "rmitchell", FirstName = "Ruby", LastName = "Mitchell", Email = "ruby.m@boardgames.com", JoinDate = DateTime.Parse("2025-04-01") },
                new User { UserID = 11, Username = "bmitchell", FirstName = "Bagel", LastName = "Mitchell", Email = "bagel.m@boardgames.com", JoinDate = DateTime.Parse("2025-04-05") },
                new User { UserID = 12, Username = "cmitchell", FirstName = "Charlie", LastName = "Mitchell", Email = "charlie.m@boardgames.com", JoinDate = DateTime.Parse("2025-04-10") },
                new User { UserID = 13, Username = "ccmitchell", FirstName = "Cream-Cheese", LastName = "Mitchell", Email = "creamcheese.m@boardgames.com", JoinDate = DateTime.Parse("2025-04-15") },
                new User { UserID = 14, Username = "bzimmerman", FirstName = "Brock", LastName = "Zimmerman", Email = "brock.z@boardgames.com", JoinDate = DateTime.Parse("2025-05-01") }
            );

            // Seed Games (15 specific + 25 popular)
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = 1, GameName = "Flip 7", MinPlayers = 2, MaxPlayers = 7, IsCompetitive = true, IsCardGame = true, AgeMinimum = 8, GameGenre = Game.Genre.Party, Complexity = 1, AverageSession = 20 },
                new Game { GameID = 2, GameName = "Fluxx", MinPlayers = 2, MaxPlayers = 6, IsCompetitive = true, IsCardGame = true, AgeMinimum = 8, GameGenre = Game.Genre.Party, Complexity = 1, AverageSession = 10 },
                new Game { GameID = 3, GameName = "Fluxx Marvel", MinPlayers = 2, MaxPlayers = 6, IsCompetitive = true, IsCardGame = true, AgeMinimum = 10, GameGenre = Game.Genre.Party, Complexity = 1, AverageSession = 15 },
                new Game { GameID = 4, GameName = "One Night Revolution", MinPlayers = 4, MaxPlayers = 10, IsCompetitive = true, IsCardGame = true, AgeMinimum = 14, GameGenre = Game.Genre.Party, Complexity = 2, AverageSession = 15 },
                new Game { GameID = 5, GameName = "The Resistance", MinPlayers = 5, MaxPlayers = 10, IsCompetitive = true, IsCardGame = true, AgeMinimum = 13, GameGenre = Game.Genre.Party, Complexity = 2, AverageSession = 30 },
                new Game { GameID = 6, GameName = "Secret Hitler", MinPlayers = 5, MaxPlayers = 10, IsCompetitive = true, IsCardGame = true, AgeMinimum = 17, GameGenre = Game.Genre.Party, Complexity = 3, AverageSession = 45 },
                new Game { GameID = 7, GameName = "Flamecraft", MinPlayers = 2, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Family, Complexity = 2, AverageSession = 60 },
                new Game { GameID = 8, GameName = "Bohnanza", MinPlayers = 2, MaxPlayers = 7, IsCompetitive = true, IsCardGame = true, AgeMinimum = 13, GameGenre = Game.Genre.Family, Complexity = 2, AverageSession = 45 },
                new Game { GameID = 9, GameName = "Just One", MinPlayers = 3, MaxPlayers = 7, IsCompetitive = true, IsCardGame = true, AgeMinimum = 8, GameGenre = Game.Genre.Party, Complexity = 1, AverageSession = 20 },
                new Game { GameID = 10, GameName = "So Clover", MinPlayers = 3, MaxPlayers = 8, IsCompetitive = true, IsCardGame = true, AgeMinimum = 10, GameGenre = Game.Genre.Party, Complexity = 2, AverageSession = 30 },
                new Game { GameID = 11, GameName = "Herd Mentality", MinPlayers = 4, MaxPlayers = 8, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Party, Complexity = 1, AverageSession = 30 },
                new Game { GameID = 12, GameName = "Dice Throne", MinPlayers = 2, MaxPlayers = 6, IsCompetitive = true, IsCardGame = false, AgeMinimum = 14, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 30 },
                new Game { GameID = 13, GameName = "Betrayal at House on the Hill", MinPlayers = 3, MaxPlayers = 6, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Party, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 14, GameName = "Catan", MinPlayers = 3, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 90 },
                new Game { GameID = 15, GameName = "Ticket to Ride", MinPlayers = 2, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 8, GameGenre = Game.Genre.Family, Complexity = 2, AverageSession = 45 },
                new Game { GameID = 16, GameName = "Wingspan", MinPlayers = 1, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 17, GameName = "Pandemic", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = false, IsCardGame = false, AgeMinimum = 8, GameGenre = Game.Genre.Cooperative, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 18, GameName = "Codenames", MinPlayers = 2, MaxPlayers = 8, IsCompetitive = true, IsCardGame = true, AgeMinimum = 14, GameGenre = Game.Genre.Party, Complexity = 2, AverageSession = 15 },
                new Game { GameID = 19, GameName = "Scythe", MinPlayers = 1, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 14, GameGenre = Game.Genre.Strategy, Complexity = 4, AverageSession = 90 },
                new Game { GameID = 20, GameName = "Gloomhaven", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = false, IsCardGame = false, AgeMinimum = 14, GameGenre = Game.Genre.Strategy, Complexity = 5, AverageSession = 120 },
                new Game { GameID = 21, GameName = "Terraforming Mars", MinPlayers = 1, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 4, AverageSession = 120 },
                new Game { GameID = 22, GameName = "Azul", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 8, GameGenre = Game.Genre.Abstract, Complexity = 2, AverageSession = 30 },
                new Game { GameID = 23, GameName = "Carcassonne", MinPlayers = 2, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 7, GameGenre = Game.Genre.Family, Complexity = 2, AverageSession = 45 },
                new Game { GameID = 24, GameName = "7 Wonders", MinPlayers = 3, MaxPlayers = 7, IsCompetitive = true, IsCardGame = true, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 30 },
                new Game { GameID = 25, GameName = "Dominion", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = true, IsCardGame = true, AgeMinimum = 14, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 30 },
                new Game { GameID = 26, GameName = "Splendor", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 2, AverageSession = 30 },
                new Game { GameID = 27, GameName = "Stone Age", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 90 },
                new Game { GameID = 28, GameName = "Power Grid", MinPlayers = 2, MaxPlayers = 6, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 4, AverageSession = 120 },
                new Game { GameID = 29, GameName = "Agricola", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 4, AverageSession = 120 },
                new Game { GameID = 30, GameName = "Le Havre", MinPlayers = 1, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 4, AverageSession = 120 },
                new Game { GameID = 31, GameName = "Concordia", MinPlayers = 2, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 100 },
                new Game { GameID = 32, GameName = "Istanbul", MinPlayers = 2, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 33, GameName = "The Voyages of Marco Polo", MinPlayers = 2, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 90 },
                new Game { GameID = 34, GameName = "Lords of Waterdeep", MinPlayers = 2, MaxPlayers = 6, IsCompetitive = true, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 35, GameName = "Castles of Mad King Ludwig", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 90 },
                new Game { GameID = 36, GameName = "Sagrada", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Abstract, Complexity = 2, AverageSession = 45 },
                new Game { GameID = 37, GameName = "Everdell", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = true, IsCardGame = false, AgeMinimum = 13, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 80 },
                new Game { GameID = 38, GameName = "Wingspan: Oceania", MinPlayers = 1, MaxPlayers = 5, IsCompetitive = true, IsCardGame = false, AgeMinimum = 10, GameGenre = Game.Genre.Strategy, Complexity = 3, AverageSession = 60 },
                new Game { GameID = 39, GameName = "Fate of the Fellowship", MinPlayers = 1, MaxPlayers = 4, IsCompetitive = false, IsCardGame = false, AgeMinimum = 12, GameGenre = Game.Genre.Cooperative, Complexity = 3, AverageSession = 90 }
            );

            // Seed Collections (one per user, with CollectionID = UserID for simplicity)
            modelBuilder.Entity<Collection>().HasData(
                new Collection { CollectionID = 1, UserID = 1 },
                new Collection { CollectionID = 2, UserID = 2 },
                new Collection { CollectionID = 3, UserID = 3 },
                new Collection { CollectionID = 4, UserID = 4 },
                new Collection { CollectionID = 5, UserID = 5 },
                new Collection { CollectionID = 6, UserID = 6 },
                new Collection { CollectionID = 7, UserID = 7 },
                new Collection { CollectionID = 8, UserID = 8 },
                new Collection { CollectionID = 9, UserID = 9 },
                new Collection { CollectionID = 10, UserID = 10 },
                new Collection { CollectionID = 11, UserID = 11 },
                new Collection { CollectionID = 12, UserID = 12 },
                new Collection { CollectionID = 13, UserID = 13 },
                new Collection { CollectionID = 14, UserID = 14 }
            );

            // Seed CollectionGames (assign 3-5 games per user)
            modelBuilder.Entity<CollectionGame>().HasData(
                // User 1 (Sarah): Games 1-4
                new CollectionGame { CollectionGameID = 1, CollectionID = 1, GameID = 1, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 2, CollectionID = 1, GameID = 2, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 3, CollectionID = 1, GameID = 3, Condition = "New", PersonalRating = 10 },
                new CollectionGame { CollectionGameID = 4, CollectionID = 1, GameID = 4, Condition = "Used", PersonalRating = 7 },
                // User 2 (Cody): Games 5-8
                new CollectionGame { CollectionGameID = 5, CollectionID = 2, GameID = 5, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 6, CollectionID = 2, GameID = 6, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 7, CollectionID = 2, GameID = 7, Condition = "New", PersonalRating = 10 },
                new CollectionGame { CollectionGameID = 8, CollectionID = 2, GameID = 8, Condition = "Used", PersonalRating = 7 },
                // User 3 (Connor): Games 9-12
                new CollectionGame { CollectionGameID = 9, CollectionID = 3, GameID = 9, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 10, CollectionID = 3, GameID = 10, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 11, CollectionID = 3, GameID = 11, Condition = "New", PersonalRating = 10 },
                new CollectionGame { CollectionGameID = 12, CollectionID = 3, GameID = 12, Condition = "Used", PersonalRating = 7 },
                // User 4 (Ashedzi): Games 13-15
                new CollectionGame { CollectionGameID = 13, CollectionID = 4, GameID = 13, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 14, CollectionID = 4, GameID = 14, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 15, CollectionID = 4, GameID = 15, Condition = "New", PersonalRating = 10 },
                // User 5 (Ayomide): Games 16-19
                new CollectionGame { CollectionGameID = 16, CollectionID = 5, GameID = 16, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 17, CollectionID = 5, GameID = 17, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 18, CollectionID = 5, GameID = 18, Condition = "New", PersonalRating = 10 },
                new CollectionGame { CollectionGameID = 19, CollectionID = 5, GameID = 19, Condition = "Used", PersonalRating = 7 },
                // User 6 (Navjot): Games 20-23
                new CollectionGame { CollectionGameID = 20, CollectionID = 6, GameID = 20, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 21, CollectionID = 6, GameID = 21, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 22, CollectionID = 6, GameID = 22, Condition = "New", PersonalRating = 10 },
                new CollectionGame { CollectionGameID = 23, CollectionID = 6, GameID = 23, Condition = "Used", PersonalRating = 7 },
                // User 7 (Xiyu): Games 24-26
                new CollectionGame { CollectionGameID = 24, CollectionID = 7, GameID = 24, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 25, CollectionID = 7, GameID = 25, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 26, CollectionID = 7, GameID = 26, Condition = "New", PersonalRating = 10 },
                // User 8 (Haodi): Games 27-29
                new CollectionGame { CollectionGameID = 27, CollectionID = 8, GameID = 27, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 28, CollectionID = 8, GameID = 28, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 29, CollectionID = 8, GameID = 29, Condition = "New", PersonalRating = 10 },
                // User 9 (Jasper): Games 30-32
                new CollectionGame { CollectionGameID = 30, CollectionID = 9, GameID = 30, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 31, CollectionID = 9, GameID = 31, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 32, CollectionID = 9, GameID = 32, Condition = "New", PersonalRating = 10 },
                // User 10 (Ruby): Games 33-35
                new CollectionGame { CollectionGameID = 33, CollectionID = 10, GameID = 33, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 34, CollectionID = 10, GameID = 34, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 35, CollectionID = 10, GameID = 35, Condition = "New", PersonalRating = 10 },
                // User 11 (Bagel): Games 1-3 (cycle back)
                new CollectionGame { CollectionGameID = 36, CollectionID = 11, GameID = 1, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 37, CollectionID = 11, GameID = 2, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 38, CollectionID = 11, GameID = 3, Condition = "New", PersonalRating = 10 },
                // User 12 (Charlie): Games 4-6
                new CollectionGame { CollectionGameID = 39, CollectionID = 12, GameID = 4, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 40, CollectionID = 12, GameID = 5, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 41, CollectionID = 12, GameID = 6, Condition = "New", PersonalRating = 10 },
                // User 13 (Cream-Cheese): Games 7-9
                new CollectionGame { CollectionGameID = 42, CollectionID = 13, GameID = 7, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 43, CollectionID = 13, GameID = 8, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 44, CollectionID = 13, GameID = 9, Condition = "New", PersonalRating = 10 },
                // User 14 (Brock): Games 10-12
                new CollectionGame { CollectionGameID = 45, CollectionID = 14, GameID = 10, Condition = "New", PersonalRating = 9 },
                new CollectionGame { CollectionGameID = 46, CollectionID = 14, GameID = 11, Condition = "Used", PersonalRating = 8 },
                new CollectionGame { CollectionGameID = 47, CollectionID = 14, GameID = 12, Condition = "New", PersonalRating = 10 }
            );

            // Seed Sessions (3 per user, with random participants, scores, winners)
            modelBuilder.Entity<Session>().HasData(
                // User 1 sessions
                new Session { SessionID = 1, GameID = 1, PlayDate = DateTime.Parse("2025-02-01"), LengthOfTime = 25, Summary = "Fun flip 7 game night", WinnerID = 1 },
                new Session { SessionID = 2, GameID = 2, PlayDate = DateTime.Parse("2025-02-15"), LengthOfTime = 15, Summary = "Quick fluxx round", WinnerID = 2 },
                new Session { SessionID = 3, GameID = 3, PlayDate = DateTime.Parse("2025-03-01"), LengthOfTime = 20, Summary = "Marvel fluxx chaos", WinnerID = 1 },
                // User 2 sessions
                new Session { SessionID = 4, GameID = 5, PlayDate = DateTime.Parse("2025-02-20"), LengthOfTime = 35, Summary = "Resistance betrayal", WinnerID = 3 },
                new Session { SessionID = 5, GameID = 6, PlayDate = DateTime.Parse("2025-03-05"), LengthOfTime = 50, Summary = "Secret Hitler intrigue", WinnerID = 2 },
                new Session { SessionID = 6, GameID = 7, PlayDate = DateTime.Parse("2025-03-10"), LengthOfTime = 65, Summary = "Flamecraft dragons", WinnerID = 4 },
                // User 3 sessions
                new Session { SessionID = 7, GameID = 9, PlayDate = DateTime.Parse("2025-03-15"), LengthOfTime = 25, Summary = "Just One guesses", WinnerID = 1 },
                new Session { SessionID = 8, GameID = 10, PlayDate = DateTime.Parse("2025-03-20"), LengthOfTime = 35, Summary = "So Clover words", WinnerID = 3 },
                new Session { SessionID = 9, GameID = 11, PlayDate = DateTime.Parse("2025-04-01"), LengthOfTime = 35, Summary = "Herd Mentality herd", WinnerID = 5 },
                // User 4 sessions
                new Session { SessionID = 10, GameID = 12, PlayDate = DateTime.Parse("2025-04-05"), LengthOfTime = 35, Summary = "Dice Throne battles", WinnerID = 4 },
                new Session { SessionID = 11, GameID = 13, PlayDate = DateTime.Parse("2025-04-10"), LengthOfTime = 70, Summary = "Betrayal haunt", WinnerID = 6 },
                new Session { SessionID = 12, GameID = 14, PlayDate = DateTime.Parse("2025-04-15"), LengthOfTime = 95, Summary = "Catan trades", WinnerID = 4 },
                // User 5 sessions
                new Session { SessionID = 13, GameID = 15, PlayDate = DateTime.Parse("2025-04-20"), LengthOfTime = 50, Summary = "Ticket to Ride routes", WinnerID = 5 },
                new Session { SessionID = 14, GameID = 16, PlayDate = DateTime.Parse("2025-05-01"), LengthOfTime = 65, Summary = "Wingspan birds", WinnerID = 7 },
                new Session { SessionID = 15, GameID = 17, PlayDate = DateTime.Parse("2025-05-05"), LengthOfTime = 65, Summary = "Pandemic cure", WinnerID = 5 },
                // User 6 sessions
                new Session { SessionID = 16, GameID = 18, PlayDate = DateTime.Parse("2025-05-10"), LengthOfTime = 20, Summary = "Codenames words", WinnerID = 6 },
                new Session { SessionID = 17, GameID = 19, PlayDate = DateTime.Parse("2025-05-15"), LengthOfTime = 95, Summary = "Scythe mechs", WinnerID = 8 },
                new Session { SessionID = 18, GameID = 20, PlayDate = DateTime.Parse("2025-05-20"), LengthOfTime = 125, Summary = "Gloomhaven quests", WinnerID = 6 },
                // User 7 sessions
                new Session { SessionID = 19, GameID = 21, PlayDate = DateTime.Parse("2025-05-25"), LengthOfTime = 125, Summary = "Terraforming Mars", WinnerID = 7 },
                new Session { SessionID = 20, GameID = 22, PlayDate = DateTime.Parse("2025-06-01"), LengthOfTime = 35, Summary = "Azul tiles", WinnerID = 9 },
                new Session { SessionID = 21, GameID = 23, PlayDate = DateTime.Parse("2025-06-05"), LengthOfTime = 50, Summary = "Carcassonne tiles", WinnerID = 7 },
                // User 8 sessions
                new Session { SessionID = 22, GameID = 24, PlayDate = DateTime.Parse("2025-06-10"), LengthOfTime = 35, Summary = "7 Wonders wonders", WinnerID = 8 },
                new Session { SessionID = 23, GameID = 25, PlayDate = DateTime.Parse("2025-06-15"), LengthOfTime = 35, Summary = "Dominion decks", WinnerID = 10 },
                new Session { SessionID = 24, GameID = 26, PlayDate = DateTime.Parse("2025-06-20"), LengthOfTime = 35, Summary = "Splendor gems", WinnerID = 8 },
                // User 9 sessions
                new Session { SessionID = 25, GameID = 27, PlayDate = DateTime.Parse("2025-06-25"), LengthOfTime = 95, Summary = "Stone Age tools", WinnerID = 9 },
                new Session { SessionID = 26, GameID = 28, PlayDate = DateTime.Parse("2025-07-01"), LengthOfTime = 125, Summary = "Power Grid power", WinnerID = 11 },
                new Session { SessionID = 27, GameID = 29, PlayDate = DateTime.Parse("2025-07-05"), LengthOfTime = 125, Summary = "Agricola farms", WinnerID = 9 },
                // User 10 sessions
                new Session { SessionID = 28, GameID = 30, PlayDate = DateTime.Parse("2025-07-10"), LengthOfTime = 125, Summary = "Le Havre ports", WinnerID = 10 },
                new Session { SessionID = 29, GameID = 31, PlayDate = DateTime.Parse("2025-07-15"), LengthOfTime = 105, Summary = "Concordia trade", WinnerID = 12 },
                new Session { SessionID = 30, GameID = 32, PlayDate = DateTime.Parse("2025-07-20"), LengthOfTime = 65, Summary = "Istanbul markets", WinnerID = 10 },
                // User 11 sessions
                new Session { SessionID = 31, GameID = 33, PlayDate = DateTime.Parse("2025-07-25"), LengthOfTime = 95, Summary = "Marco Polo voyages", WinnerID = 11 },
                new Session { SessionID = 32, GameID = 34, PlayDate = DateTime.Parse("2025-08-01"), LengthOfTime = 65, Summary = "Waterdeep lords", WinnerID = 13 },
                new Session { SessionID = 33, GameID = 35, PlayDate = DateTime.Parse("2025-08-05"), LengthOfTime = 95, Summary = "Mad King Ludwig castles", WinnerID = 11 },
                // User 12 sessions
                new Session { SessionID = 34, GameID = 36, PlayDate = DateTime.Parse("2025-08-10"), LengthOfTime = 50, Summary = "Sagrada stained glass", WinnerID = 12 },
                new Session { SessionID = 35, GameID = 37, PlayDate = DateTime.Parse("2025-08-15"), LengthOfTime = 85, Summary = "Everdell critters", WinnerID = 14 },
                new Session { SessionID = 36, GameID = 38, PlayDate = DateTime.Parse("2025-08-20"), LengthOfTime = 65, Summary = "Wingspan Oceania birds", WinnerID = 12 },
                // User 13 sessions
                new Session { SessionID = 37, GameID = 14, PlayDate = DateTime.Parse("2025-08-25"), LengthOfTime = 95, Summary = "Catan trades", WinnerID = 13 },
                new Session { SessionID = 38, GameID = 15, PlayDate = DateTime.Parse("2025-09-01"), LengthOfTime = 50, Summary = "Ticket to Ride routes", WinnerID = 1 },
                new Session { SessionID = 39, GameID = 16, PlayDate = DateTime.Parse("2025-09-05"), LengthOfTime = 65, Summary = "Wingspan birds", WinnerID = 13 },
                // User 14 sessions
                new Session { SessionID = 40, GameID = 17, PlayDate = DateTime.Parse("2025-09-10"), LengthOfTime = 65, Summary = "Pandemic cure", WinnerID = 14 },
                new Session { SessionID = 41, GameID = 18, PlayDate = DateTime.Parse("2025-09-15"), LengthOfTime = 20, Summary = "Codenames words", WinnerID = 2 },
                new Session { SessionID = 42, GameID = 19, PlayDate = DateTime.Parse("2025-09-20"), LengthOfTime = 95, Summary = "Scythe mechs", WinnerID = 14 }
            );

            // Seed PlayParticipants (2-4 per session, with scores and IsWinner)
            modelBuilder.Entity<PlayParticipant>().HasData(
            // Session 1 participants (Users 1, 2, 3)
            new PlayParticipant { ParticipantID = 1, SessionID = 1, UserID = 1, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 2, SessionID = 1, UserID = 2, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 3, SessionID = 1, UserID = 3, Score = 11, IsWinner = false },
            // Session 2 participants (Users 2, 1)
            new PlayParticipant { ParticipantID = 4, SessionID = 2, UserID = 2, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 5, SessionID = 2, UserID = 1, Score = 10, IsWinner = false },
            // Session 3 participants (Users 1, 3, 4)
            new PlayParticipant { ParticipantID = 6, SessionID = 3, UserID = 1, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 7, SessionID = 3, UserID = 3, Score = 8, IsWinner = false },
            new PlayParticipant { ParticipantID = 8, SessionID = 3, UserID = 4, Score = 12, IsWinner = false },
            // Session 4 participants (Users 3, 2, 5, 1)
            new PlayParticipant { ParticipantID = 9, SessionID = 4, UserID = 3, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 10, SessionID = 4, UserID = 2, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 11, SessionID = 4, UserID = 5, Score = 13, IsWinner = false },
            new PlayParticipant { ParticipantID = 12, SessionID = 4, UserID = 1, Score = 10, IsWinner = false },
            // Session 5 participants (Users 2, 3, 6)
            new PlayParticipant { ParticipantID = 13, SessionID = 5, UserID = 2, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 14, SessionID = 5, UserID = 3, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 15, SessionID = 5, UserID = 6, Score = 12, IsWinner = false },
            // Session 6 participants (Users 4, 2, 7)
            new PlayParticipant { ParticipantID = 16, SessionID = 6, UserID = 4, Score = 11, IsWinner = true },
            new PlayParticipant { ParticipantID = 17, SessionID = 6, UserID = 2, Score = 13, IsWinner = false },
            new PlayParticipant { ParticipantID = 18, SessionID = 6, UserID = 7, Score = 10, IsWinner = false },
            // Session 7 participants (Users 1, 3, 5)
            new PlayParticipant { ParticipantID = 19, SessionID = 7, UserID = 1, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 20, SessionID = 7, UserID = 3, Score = 8, IsWinner = false },
            new PlayParticipant { ParticipantID = 21, SessionID = 7, UserID = 5, Score = 11, IsWinner = false },
            // Session 8 participants (Users 3, 1, 8)
            new PlayParticipant { ParticipantID = 22, SessionID = 8, UserID = 3, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 23, SessionID = 8, UserID = 1, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 24, SessionID = 8, UserID = 8, Score = 12, IsWinner = false },
            // Session 9 participants (Users 5, 3, 9)
            new PlayParticipant { ParticipantID = 25, SessionID = 9, UserID = 5, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 26, SessionID = 9, UserID = 3, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 27, SessionID = 9, UserID = 9, Score = 11, IsWinner = false },
            // Session 10 participants (Users 4, 6, 2)
            new PlayParticipant { ParticipantID = 28, SessionID = 10, UserID = 4, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 29, SessionID = 10, UserID = 6, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 30, SessionID = 10, UserID = 2, Score = 13, IsWinner = false },
            // Session 11 participants (Users 6, 4, 10)
            new PlayParticipant { ParticipantID = 31, SessionID = 11, UserID = 6, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 32, SessionID = 11, UserID = 4, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 33, SessionID = 11, UserID = 10, Score = 14, IsWinner = false },
            // Session 12 participants (Users 4, 8, 12)
            new PlayParticipant { ParticipantID = 34, SessionID = 12, UserID = 4, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 35, SessionID = 12, UserID = 8, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 36, SessionID = 12, UserID = 12, Score = 12, IsWinner = false },
            // Session 13 participants (Users 5, 7, 1)
            new PlayParticipant { ParticipantID = 37, SessionID = 13, UserID = 5, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 38, SessionID = 13, UserID = 7, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 39, SessionID = 13, UserID = 1, Score = 11, IsWinner = false },
            // Session 14 participants (Users 5, 9, 13)
            new PlayParticipant { ParticipantID = 40, SessionID = 14, UserID = 5, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 41, SessionID = 14, UserID = 9, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 42, SessionID = 14, UserID = 13, Score = 13, IsWinner = false },
            // Session 15 participants (Users 5, 11, 14)
            new PlayParticipant { ParticipantID = 43, SessionID = 15, UserID = 5, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 44, SessionID = 15, UserID = 11, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 45, SessionID = 15, UserID = 14, Score = 11, IsWinner = false },
            // Session 16 participants (Users 6, 2, 4)
            new PlayParticipant { ParticipantID = 46, SessionID = 16, UserID = 6, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 47, SessionID = 16, UserID = 2, Score = 8, IsWinner = false },
            new PlayParticipant { ParticipantID = 48, SessionID = 16, UserID = 4, Score = 12, IsWinner = false },
            // Session 17 participants (Users 8, 6, 10)
            new PlayParticipant { ParticipantID = 49, SessionID = 17, UserID = 8, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 50, SessionID = 17, UserID = 6, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 51, SessionID = 17, UserID = 10, Score = 13, IsWinner = false },
            // Session 18 participants (Users 6, 12, 14)
            new PlayParticipant { ParticipantID = 52, SessionID = 18, UserID = 6, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 53, SessionID = 18, UserID = 12, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 54, SessionID = 18, UserID = 14, Score = 14, IsWinner = false },
            // Session 19 participants (Users 7, 1, 3)
            new PlayParticipant { ParticipantID = 55, SessionID = 19, UserID = 7, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 56, SessionID = 19, UserID = 1, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 57, SessionID = 19, UserID = 3, Score = 11, IsWinner = false },
            // Session 20 participants (Users 9, 7, 11)
            new PlayParticipant { ParticipantID = 58, SessionID = 20, UserID = 9, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 59, SessionID = 20, UserID = 7, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 60, SessionID = 20, UserID = 11, Score = 12, IsWinner = false },
            // Session 21 participants (Users 7, 13, 2)
            new PlayParticipant { ParticipantID = 61, SessionID = 21, UserID = 7, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 62, SessionID = 21, UserID = 13, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 63, SessionID = 21, UserID = 2, Score = 13, IsWinner = false },
            // Session 22 participants (Users 8, 4, 6)
            new PlayParticipant { ParticipantID = 64, SessionID = 22, UserID = 8, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 65, SessionID = 22, UserID = 4, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 66, SessionID = 22, UserID = 6, Score = 14, IsWinner = false },
            // Session 23 participants (Users 10, 8, 12)
            new PlayParticipant { ParticipantID = 67, SessionID = 23, UserID = 10, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 68, SessionID = 23, UserID = 8, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 69, SessionID = 23, UserID = 12, Score = 11, IsWinner = false },
            // Session 24 participants (Users 8, 14, 1)
            new PlayParticipant { ParticipantID = 70, SessionID = 24, UserID = 8, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 71, SessionID = 24, UserID = 14, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 72, SessionID = 24, UserID = 1, Score = 12, IsWinner = false },
            // Session 25 participants (Users 9, 5, 7)
            new PlayParticipant { ParticipantID = 73, SessionID = 25, UserID = 9, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 74, SessionID = 25, UserID = 5, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 75, SessionID = 25, UserID = 7, Score = 13, IsWinner = false },
            // Session 26 participants (Users 11, 9, 13)
            new PlayParticipant { ParticipantID = 76, SessionID = 26, UserID = 11, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 77, SessionID = 26, UserID = 9, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 78, SessionID = 26, UserID = 13, Score = 14, IsWinner = false },
            // Session 27 participants (Users 9, 1, 3)
            new PlayParticipant { ParticipantID = 79, SessionID = 27, UserID = 9, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 80, SessionID = 27, UserID = 1, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 81, SessionID = 27, UserID = 3, Score = 11, IsWinner = false },
            // Session 28 participants (Users 10, 2, 4)
            new PlayParticipant { ParticipantID = 82, SessionID = 28, UserID = 10, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 83, SessionID = 28, UserID = 2, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 84, SessionID = 28, UserID = 4, Score = 12, IsWinner = false },
            // Session 29 participants (Users 12, 10, 14)
            new PlayParticipant { ParticipantID = 85, SessionID = 29, UserID = 12, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 86, SessionID = 29, UserID = 10, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 87, SessionID = 29, UserID = 14, Score = 13, IsWinner = false },
            // Session 30 participants (Users 10, 6, 8)
            new PlayParticipant { ParticipantID = 88, SessionID = 30, UserID = 10, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 89, SessionID = 30, UserID = 6, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 90, SessionID = 30, UserID = 8, Score = 14, IsWinner = false },
            // Session 31 participants (Users 11, 7, 9)
            new PlayParticipant { ParticipantID = 91, SessionID = 31, UserID = 11, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 92, SessionID = 31, UserID = 7, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 93, SessionID = 31, UserID = 9, Score = 11, IsWinner = false },
            // Session 32 participants (Users 13, 11, 1)
            new PlayParticipant { ParticipantID = 94, SessionID = 32, UserID = 13, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 95, SessionID = 32, UserID = 11, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 96, SessionID = 32, UserID = 1, Score = 12, IsWinner = false },
            // Session 33 participants (Users 11, 3, 5)
            new PlayParticipant { ParticipantID = 97, SessionID = 33, UserID = 11, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 98, SessionID = 33, UserID = 3, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 99, SessionID = 33, UserID = 5, Score = 13, IsWinner = false },
            // Session 34 participants (Users 12, 8, 10)
            new PlayParticipant { ParticipantID = 100, SessionID = 34, UserID = 12, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 101, SessionID = 34, UserID = 8, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 102, SessionID = 34, UserID = 10, Score = 14, IsWinner = false },
            // Session 35 participants (Users 14, 12, 2)
            new PlayParticipant { ParticipantID = 103, SessionID = 35, UserID = 14, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 104, SessionID = 35, UserID = 12, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 105, SessionID = 35, UserID = 2, Score = 11, IsWinner = false },
            // Session 36 participants (Users 12, 4, 6)
            new PlayParticipant { ParticipantID = 106, SessionID = 36, UserID = 12, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 107, SessionID = 36, UserID = 4, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 108, SessionID = 36, UserID = 6, Score = 12, IsWinner = false },
            // Session 37 participants (Users 13, 9, 11)
            new PlayParticipant { ParticipantID = 109, SessionID = 37, UserID = 13, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 110, SessionID = 37, UserID = 9, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 111, SessionID = 37, UserID = 11, Score = 13, IsWinner = false },
            // Session 38 participants (Users 1, 13, 7)
            new PlayParticipant { ParticipantID = 112, SessionID = 38, UserID = 1, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 113, SessionID = 38, UserID = 13, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 114, SessionID = 38, UserID = 7, Score = 14, IsWinner = false },
            // Session 39 participants (Users 13, 5, 3)
            new PlayParticipant { ParticipantID = 115, SessionID = 39, UserID = 13, Score = 12, IsWinner = true },
            new PlayParticipant { ParticipantID = 116, SessionID = 39, UserID = 5, Score = 9, IsWinner = false },
            new PlayParticipant { ParticipantID = 117, SessionID = 39, UserID = 3, Score = 11, IsWinner = false },
            // Session 40 participants (Users 14, 10, 12)
            new PlayParticipant { ParticipantID = 118, SessionID = 40, UserID = 14, Score = 13, IsWinner = true },
            new PlayParticipant { ParticipantID = 119, SessionID = 40, UserID = 10, Score = 10, IsWinner = false },
            new PlayParticipant { ParticipantID = 120, SessionID = 40, UserID = 12, Score = 12, IsWinner = false },
            // Session 41 participants (Users 2, 14, 6)
            new PlayParticipant { ParticipantID = 121, SessionID = 41, UserID = 2, Score = 14, IsWinner = true },
            new PlayParticipant { ParticipantID = 122, SessionID = 41, UserID = 14, Score = 11, IsWinner = false },
            new PlayParticipant { ParticipantID = 123, SessionID = 41, UserID = 6, Score = 13, IsWinner = false },
            // Session 42 participants (Users 14, 12, 13, 2)
            new PlayParticipant { ParticipantID = 124, SessionID = 42, UserID = 14, Score = 15, IsWinner = true },
            new PlayParticipant { ParticipantID = 125, SessionID = 42, UserID = 12, Score = 12, IsWinner = false },
            new PlayParticipant { ParticipantID = 126, SessionID = 42, UserID = 13, Score = 14, IsWinner = false },
            new PlayParticipant { ParticipantID = 127, SessionID = 42, UserID = 2, Score = 11, IsWinner = false }
        );
        }
    }
}