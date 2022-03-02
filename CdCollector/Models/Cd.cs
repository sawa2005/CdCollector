namespace CdCollector.Models
{
    public class Cd
    {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ArtistId { get; set; }
        public virtual Artist? Artist { get; set; }
    }
}
