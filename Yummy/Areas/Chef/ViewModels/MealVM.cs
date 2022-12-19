using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Yummy.Data;
using Yummy.Models;

namespace Yummy.Areas.Chef.ViewModels
{
    public class MealVM
    {
        [Required(ErrorMessage = "**You must add name !")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "**You must add price !")]
        public double Price { get; set; }
        [Required(ErrorMessage = "**You must add Image!")]

        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "**You must add ingradients !")]
        public string Ingredients { get; set; } = "";
        [ForeignKey("ApplicationUser")]
        public int CategoryId { get; set; }

    }
    public class AddMealWithVM : MealVM
    {
        public List<SelectListItem> _categories { get; set; }
        public void AddMealWithCategories(List<MenuCategory> categories)
        {
            List<SelectListItem> ListOfCategories = new List<SelectListItem>();
            foreach (var category in categories)
            {
                ListOfCategories.Add(
                new SelectListItem { Text = category.Name, Value = category.Id.ToString() }
                );
            }
            _categories = ListOfCategories;
        }
    }
}
