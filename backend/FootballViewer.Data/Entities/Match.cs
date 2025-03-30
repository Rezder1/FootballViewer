using FootballViewer.Data.Interfaces;

namespace FootballViewer.Data.Entities
{
    public class Match : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public string Result { get; set; } = null!;

        public Team HomeTeam { get; set; } = null!;

        public Team GuestTeam { get; set; } = null!;
    }
}
