using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Data.Database.Context
{
    public class OnlineStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public OnlineStoreDB(DbContextOptions<OnlineStoreDB> options) : base(options) { }
    }
}
