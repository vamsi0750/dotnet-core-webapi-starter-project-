using Microsoft.EntityFrameworkCore;
using ProductManagement.API.Models;

namespace ProductManagement.API
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }


    }
}
