namespace FootballViewer.Core.Entities
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int TeamID { get; set; }

        public Team Team { get; set; }
    }
}
