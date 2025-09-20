using Board_Game_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Board_Game_API.Models {
    public class BoardGameContext : DbContext {

    //     public DbSet<Prisoner> Prisoners { get; set; }

    //public CapturedPrisonersContext(DbContextOptions<CapturedPrisonersContext> options) : base(options) { }

    //protected override void OnModelCreating(ModelBuilder modelBuilder) {
    //    //configure primary key
    //    modelBuilder.Entity<Prisoner>()
    //        .HasKey(p => p.ID);

    //    //configure properties

    //    modelBuilder.Entity<Prisoner>()
    //        .Property(p => p.Name)
    //        .IsRequired()
    //        .HasMaxLength(100);
    }
}

