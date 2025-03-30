using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FootballViewer.Data
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FootballViewerContext>
    {
        public FootballViewerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FootballViewerContext>();
            
            optionsBuilder.UseNpgsql("Host=localhost;Database=FootballViewer;Username=postgres;Password=vfvf50717");

            return new FootballViewerContext(optionsBuilder.Options);
        }
    }
}
