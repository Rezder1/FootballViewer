using FootballViewer.Data.Interfaces;

namespace FootballViewer.Data.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public Team Team { get; set; } = null!;
    }
}
