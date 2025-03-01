namespace FootballViewer.Core.Entities
{
    public class Match
    {
        public int MatchID { get; set; }
        public DateTime DateTime { get; set; }
        public int Team1ID { get; set; }
        public int Team2ID { get; set; }
        public string Result { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }
}
