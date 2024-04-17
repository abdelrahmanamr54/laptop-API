using Api_Laptop_Task.DTO;
using Api_Laptop_Task.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api_Laptop_Task.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", true, true)
               .Build()
               .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Laptop>()
            //    .HasOne(l => l.brand)
            //    .WithMany()
            //    .HasForeignKey(l => l.BrandId);
        }
        // public DbSet<Product> products { get; set; } = default!;
        //  public DbSet<ProductDTO> productsDTO { get; set; } = default!;
        public DbSet<Laptop> laptops { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<ContactUs> contactUs { get; set; }
       public DbSet<ApplicationUserDTO> applicationUserDTOs { get; set; } = default!;
    }
}
