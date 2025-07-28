using Microsoft.EntityFrameworkCore;
using EcommerceMicroservice.Models;

namespace EcommerceMicroservice.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        //FluentApi

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasKey(c => c.CategoryId);

            mb.Entity<Category>().
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();

            mb.Entity<Product>().
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();

            mb.Entity<Product>().
               Property(c => c.Description).
               HasMaxLength(255).
               IsRequired();

            mb.Entity<Product>().
              Property(c => c.ImageURL).
              HasMaxLength(255).
              IsRequired();

            mb.Entity<Product>().
             Property(c => c.Price).
             HasPrecision(12, 2);

            mb.Entity<Category>().
                HasMany(p => p.Products).
                WithOne(c => c.Category).
                OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Category>().
                HasData(
                    new Category
                    {
                        CategoryId = 1,
                        Name = "Material Escolar"
                    },
                    new Category
                    {
                        CategoryId = 2,
                        Name = "Acessórios"
                    }
                );

            base.OnModelCreating(mb);
        }
    }
}
