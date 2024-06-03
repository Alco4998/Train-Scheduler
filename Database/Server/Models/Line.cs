namespace Server.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Station StartStation { get; set; }
        public Station EndStation { get; set; }
    }
}