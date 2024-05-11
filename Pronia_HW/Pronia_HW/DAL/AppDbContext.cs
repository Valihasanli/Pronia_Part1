using Microsoft.EntityFrameworkCore;
using Pronia_HW.Models;

namespace Pronia_HW.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductPhoto> ProductsPhotos { get; set; }
    }
}
