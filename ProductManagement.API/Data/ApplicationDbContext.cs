using Microsoft.EntityFrameworkCore;

namespace ProductManagement.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<ProductManagement.API.Models.Product> Products { get; set; }
    public DbSet<ProductManagement.API.Models.Customer> Customers { get; set; }
    public DbSet<ProductManagement.API.Models.Order> Orders { get; set; }
}
