namespace Yummy.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public double Price { get; set; }
        public string Des { get; set; } = "";
        public string ImageName { get; set; } = "";
        public DateTime EventDate { get; set; } 
    }
}
