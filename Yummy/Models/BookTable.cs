namespace Yummy.Models
{
    public class BookTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime Date { get; set; } 
        public DateTime Time { get; set; } 
        public int NumberOfPeople { get; set; }
        public string Message { get; set; } = "";
    }
}
