namespace CyclingAPI.Models
{
    public class CyclingTrip
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string StartingLocation { get; set; } = string.Empty;
        public string EndLocation { get; set; } = string.Empty ;
        public double Distance { get; set; }
        public TimeSpan Duration { get; set; }
        public double AvarageSpeed { get; set; }
        public int AltitudeMeters { get; set; }
    }
}
