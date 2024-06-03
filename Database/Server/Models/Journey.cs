namespace Server.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrginStationId { get; set; }
        public int DestinationStationId { get; set; }
        public int? TrainId { get; set; }
    }
}
    