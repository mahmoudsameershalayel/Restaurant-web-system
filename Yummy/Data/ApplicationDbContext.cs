using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yummy.Models;

namespace Yummy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            //GUID
            string Admin_Role_Id = "9a00de05-ab2c-4692-82b2-d33f0f50eb7e";
            string Chef_Role_Id = "6472ca7d-4acb-4550-9b9f-2d03321ad5e6";
            string Admin_User_Id = "f1446937-109c-4e1a-97ce-0560442484f5";

            //Add Role
            Builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Admin_Role_Id,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = Admin_Role_Id

            });
            Builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Chef_Role_Id,
                Name = "Chef",
                NormalizedName = "CHEF",
                ConcurrencyStamp = Chef_Role_Id
            });
            //Add Admin User
            var adminUser = new ApplicationUser
            {
                Id = Admin_User_Id,
                FirstName = "Mahmoud",
                LastName = "Sameer",
                Email = "mahmoud@admin.com",
                NormalizedEmail = "MAHMOUD@ADMIN.COM",
                userType = UserType.Administrator,
                UserName = "Mahmoud_Sameer",
                ImageName = "ma.jpg"
                
            };

            //Password Hasher
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "123456");
            Builder.Entity<ApplicationUser>().HasData(adminUser);    
            //Add Role To AdminUser
            Builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = Admin_Role_Id,
                    UserId = Admin_User_Id
                }
                ) ;
            
            Builder.Entity<MenuCategory>().HasData(
                new MenuCategory { Id = 1, Name = "Breakfast" },
                new MenuCategory { Id = 2, Name = "Launch" },
                new MenuCategory { Id = 3, Name = "Dinner" }
            );
            base.OnModelCreating(Builder);
        }
        public DbSet<BookTable> Bookings { get; set; }
        public DbSet<MenuCategory> menuCategories { get; set; }
        public DbSet<Meal> meals { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<Photo> photos { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<Aboutarticle> aboutArticle { get; set; }
    }
}