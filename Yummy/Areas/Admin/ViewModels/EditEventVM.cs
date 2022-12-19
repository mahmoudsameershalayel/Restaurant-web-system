using System.ComponentModel.DataAnnotations;

namespace Yummy.Areas.Admin.ViewModels
{
    public class EditEventVM
    {
        [Required(ErrorMessage = "**You must add title")]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "**You must add price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "**You must add description")]
        public string Des { get; set; } = "";
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; } = "";
        public string EventDate { get; set; }
    }
}
