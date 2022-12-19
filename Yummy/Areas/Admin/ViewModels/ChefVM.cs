namespace Yummy.Areas.Admin.ViewModels
{
    public class ChefVM
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        //Files/Images/imagename.jpg
        public IFormFile? Image { get; set; }
        public string? JopTitle { get; set; }
        public string? Description { get; set; }
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
