using System.ComponentModel.DataAnnotations;

namespace Yummy.ViewModels
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Your name is required" )]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "Your email is required")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Your subject is required")]
        public string Subject { get; set; } = "";
        [Required(ErrorMessage = "Your message is required")]
        public string Message { get; set; } = "";
    }
}
