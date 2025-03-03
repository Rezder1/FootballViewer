using FootballViewer.Data.Interfaces;

namespace FootballViewer.Data.Entities
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}