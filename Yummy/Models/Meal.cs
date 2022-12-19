using System.ComponentModel.DataAnnotations.Schema;
using Yummy.Areas.Admin.ViewModels;
using Yummy.Data;

namespace Yummy.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public string ImageName { get; set; } = "";
        public string Ingredients { get; set; } = "";
        [ForeignKey("ApplicationUser")]
        public string ChefId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int CategoryId { get; set; }
        public MenuCategory Category { get; set; }
    }
}
