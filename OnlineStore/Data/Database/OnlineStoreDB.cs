using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.DAL
{
    public class OnlineStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }
        OnlineStoreDB(DbContextOptions<OnlineStoreDB> options) : base(options) { }
    }
}
