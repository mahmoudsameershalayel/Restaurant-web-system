namespace Yummy.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Meal> meals { get; set; }
    }
}
