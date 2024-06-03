namespace Server.Models
{
    public class Train
    {
        public int Id { get; set; }
        public int Cars { get; set; }
        private Car CarType { get; set; }
        private List<Journey> Journeys = new List<Journey>();
        public Line? line { get; set; }
        public Station? currentStation { get; set; }
        public Station? NextStation { get; set; }
        public Station? PreviousSatation { get; set; }
    }
}