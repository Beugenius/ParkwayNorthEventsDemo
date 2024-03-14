using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ParkwayNorthEvents.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ServicesBooked> ServicesBooked => Set<ServicesBooked>();
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<EventGallery> EventGallery { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<VenuesBooked> VenuesBooked { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seeding roles in the AspNetRoles table 
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81", Name = SD.ManagerRole, NormalizedName = SD.ManagerRole.ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "fe712b7e-2f2a-443a-8382-6f4c46e9446e", Name = SD.AdminRole, NormalizedName = SD.AdminRole.ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "5b562406-58d9-45c5-99a5-a9c6a4fad5db", Name = SD.ClientRole, NormalizedName = SD.ClientRole.ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3aad443b-079e-49e8-9888-caa52f6a2c00", Name = SD.UnregisteredClient, NormalizedName = SD.UnregisteredClient.ToUpper() });
            // a hasher to hash the password before db seeding 
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = "eb45d5df-4c1d-4126-9977-797ff21a8e18",
                UserName = "Admin@ParkwayNorthEvents.com",
                Email = "Admin@ParkwayNorthEvents.com",
                FirstName = "Parkway",
                LastName = "Admin",
                NormalizedEmail = "ADMIN@PARKWAYNORTHEVENTS.COM",
                NormalizedUserName = "ADMIN@PARKWAYNORTHEVENTS.COM",
                PasswordHash = hasher.HashPassword(null, "ENTER PASSWORD")
            });

            builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = "299ef036-7cc4-4434-9bb6-58475c9cec84",
                UserName = "Management@ParkwayNorthEvents.com",
                Email = "Management@ParkwayNorthEvents.com",
                FirstName = "Parkway",
                LastName = "Management",
                NormalizedEmail = "MANAGEMENT@PARKWAYNORTHEVENTS.COM",
                NormalizedUserName = "MANAGEMENT@PARKWAYNORTHEVENTS.COM",
                PasswordHash = hasher.HashPassword(null, "ENTER PASSWORD")
            });

            builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = "766c7898-0a5e-451a-aed7-89802904b2a2",
                UserName = "JohnDoe@ParkwayNorthEvents.com",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-456-7890",
                Email = "JohnDoe@ParkwayNorthEvents.com",
                NormalizedEmail = "JOHNDOE@PARKWAYNORTHEVENTS.COM",
                NormalizedUserName = "JOHNDOE@PARKWAYNORTHEVENTS.COM",
                PasswordHash = hasher.HashPassword(null, "ENTER PASSWORD")
            });
            builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser()
            {
                Id = "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c",
                FirstName = "Jill",
                LastName = "Bistro",
                PhoneNumber = "801-456-7891",
                Email = "JillBistro@Yahoo.mail"
            });
            // Seeding clients role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "5b562406-58d9-45c5-99a5-a9c6a4fad5db",
                UserId = "766c7898-0a5e-451a-aed7-89802904b2a2"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "3aad443b-079e-49e8-9888-caa52f6a2c00",
                UserId = "1ac5d9c8-b997-4d29-94f6-9e8f7ec71d8c"
            });

            // Seeding admin role
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "fe712b7e-2f2a-443a-8382-6f4c46e9446e",
                UserId = "eb45d5df-4c1d-4126-9977-797ff21a8e18"
            });

            // Seeding manager role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "1d94a5cd-ac11-4c72-b765-d71ae2e3fb81",
                UserId = "299ef036-7cc4-4434-9bb6-58475c9cec84"
            });
        }
    }
}