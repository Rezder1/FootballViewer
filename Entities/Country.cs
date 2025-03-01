namespace FootballViewer.Core.Entities
{
    public class Country
    {
        public int CountryID { get; set; }
        public required string Namecountry { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
