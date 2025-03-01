using Microsoft.EntityFrameworkCore;

namespace FootballViewer.Core.Repositories
{
    public class SportContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=myhost;Datebase=mydatebase;Username=myusername;Password=mypassword");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка связи между Country и Tea
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Country) // Team имеет одну Country
                .WithMany(t => t.Teams) // Country может иметь много Team
                .HasForeignKey(t => t.CountryID) // Внушний ключ
                .OnDelete(DeleteBehavior.Cascade); // При удалении страны будут удалены все команды из этой страны

            modelBuilder.Entity<Player>()
                .HasOne(p => p.Team) // Player имеет одну Team
                .WithMany(t => t.Players) // Team может иметь много Players
                .HasForeignKey(p => p.TeamID); // внешний ключ
            
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team1) // Match имеет одну Team1
                .WithMany(t => t.Matches) // Team может иметь много Matches
                .HasForeignKey(m => m.Team1ID) // внешний ключ
                .OnDelete(DeleteBehavior.Restrict); // При удалении команды не будут удалены связанные матчи
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team2) // Match имеет одну Team2
                .WithMany(t => t.Matches) // Team может иметь много Matches
                .HasForeignKey(m => m.Team1ID) // внешний ключ
                .OnDelete(DeleteBehavior.Restrict); // При удалении команды не будут удалены связанные матчи
        }
    }
}
