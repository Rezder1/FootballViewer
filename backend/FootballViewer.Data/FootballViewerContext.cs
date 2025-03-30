using FootballViewer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballViewer.Data
{
    public class FootballViewerContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public FootballViewerContext(DbContextOptions<FootballViewerContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=FootballViewer;Username=postgres;Password=vfvf50717");
            }
        }
    }
}
