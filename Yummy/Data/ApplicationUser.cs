using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        //Files/Images/imagename.jpg
        public string? ImageName { get; set; } = "";
        [Column(TypeName = "nvarchar(24)")]
        public UserType userType{ get; set; }
        public string? JopTitle { get; set; }
        public string? Description { get; set; }
    }
    public enum UserType
    {
        Administrator,
        Chef,
        User
    }
}
