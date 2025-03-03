using FootballViewer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballViewer.Data
{
    public class FotballViewerContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public FotballViewerContext(DbContextOptions<FotballViewerContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=myhost;Datebase=mydatebase;Username=myusername;Password=mypassword");
        }
    }
}
