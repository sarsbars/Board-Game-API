using Board_Game_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace Board_Game_API.Models { 
    public class BoardGameContext : Microsoft.EntityFrameworkCore.DbContext { 
        public DbSet Users { get; set; } 
        public DbSet Collections { get; set; } 
        public DbSet CollectionGames { get; set; } 
        public DbSet Games { get; set; } 
        public DbSet Sessions { get; set; } 
        public DbSet PlayParticipants { get; set; }
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
                .HasConversion<string>()
                .HasMaxLength(50);
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
        }
    }
}