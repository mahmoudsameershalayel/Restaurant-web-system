namespace Yummy.ViewModels
{
    public class BookingVM
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int NumberOfPeople { get; set; }
        public string Message { get; set; } = "";
    }
}
