using CrudDemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDemoApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}
