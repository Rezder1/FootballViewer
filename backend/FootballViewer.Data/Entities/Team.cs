using FootballViewer.Data.Interfaces;

namespace FootballViewer.Data.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public Country Country { get; set; } = null!;
    }
}
