namespace FootballViewer.Core.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public required string Nameteam { get; set; }
        public int CountryID { get; set; }

        public  Country Country { get; set; }
        public  ICollection<Player> Players { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
