using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace qrmenuproject.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<CafeContactInfo> CafeContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product { ProductId = 1, ProductName = "Ice Latte", ProductDescription = "Soguk latte", ProductPrice = 85, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },
                
                new Product { ProductId = 2, ProductName = "Ice Americano", ProductDescription = "Soguk americano", ProductPrice = 70, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },
                
                new Product { ProductId = 3, ProductName = "Cool Lime", ProductDescription = "Soguk Nane ve limon aromali icecek", ProductPrice = 100, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },
                
                new Product { ProductId = 4, ProductName = "Ice Mocha", ProductDescription = "Soguk mocha", ProductPrice = 85, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },
                
                new Product { ProductId = 5, ProductName = "Berry Lime", ProductDescription = "Soguk bogurtlenli ve limonlu icecek", ProductPrice = 100, ProductImage= "~/img/bardak_cay.jpg", CategoryId = 1 }
                );
            modelBuilder.Entity<Category>()
                .HasData(
                new Category { CategoryId = 1, CategoryName = "Soğuk içecekler" }
                );
            modelBuilder.Entity<CafeContactInfo>()
                .HasData(
                new CafeContactInfo { CafeContactInfoId=1,CafeContactInfoAddress="menuCafe@gmail.com",CafeContactInfoMail="adresimiz" }
                );
            modelBuilder.Entity<About>()
                .HasData(
                new About { AboutId = 1, AboutDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", AboutMission = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", AboutVision = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.",AboutFacebookAddress="F",AboutInstagramAddress="I",AboutWpAddress="W" }
                );
        }
    }
}
