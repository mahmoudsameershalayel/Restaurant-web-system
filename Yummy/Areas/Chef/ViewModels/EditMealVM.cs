using System.Web.Mvc;
using Yummy.Models;

namespace Yummy.Areas.Chef.ViewModels
{
    public class EditMealVM
    {

        public string? Name { get; set; } = "";
        public double? Price { get; set; }
        public IFormFile? Image { get; set; }
        public string? Ingredients { get; set; } = "";
        public int? CategoryId { get; set; }

    }
    public class EditMealWithVM : MealVM
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

