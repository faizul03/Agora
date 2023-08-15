using EShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Test Test", DisplayOrder = 10, Price = 5.99f, Quntity = 1 },
                new Category { Id = 2, Name = "Test One", DisplayOrder = 2, Price = 7.99f, Quntity = 10 },
                new Category { Id = 3, Name = "Test Two", DisplayOrder = 3, Price = 9.99f, Quntity = 3 },
                new Category { Id = 4, Name = "Test Three", DisplayOrder = 4, Price = 4.99f, Quntity = 21 },
                new Category { Id = 5, Name = "Test Four", DisplayOrder = 5, Price = 5.99f, Quntity = 12 }

                );
        }

    }

}

