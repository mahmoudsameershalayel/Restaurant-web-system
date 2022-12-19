using System.ComponentModel.DataAnnotations;
using Yummy.Models;

namespace Yummy.Areas.Admin.ViewModels
{
    public class EventsVM
    {
        [Required(ErrorMessage = "**You must add title")]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "**You must add price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "**You must add description")]
        public string Des { get; set; } = "";
        [Required(ErrorMessage = "**You must add Image")]
        public IFormFile Image { get; set; }
        public string EventDate { get; set; } = "";


    }
}
