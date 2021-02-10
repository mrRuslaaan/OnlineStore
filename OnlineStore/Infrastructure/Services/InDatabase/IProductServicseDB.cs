using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;
using OnlineStore.Data.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Infrastructure.Services.InDatabase
{
    public class IProductServicseDB : IProduct
    {
        private readonly OnlineStoreDB _db;
        public IProductServicseDB(OnlineStoreDB db) => _db = db;
        public IEnumerable<Brand> GetBrands() => _db.Brands.Include(b => b.Products);

        public IEnumerable<Category> GetCategories() => _db.Categories;

        public IEnumerable<Product> GetProducts(Filter filter = null)
        {
            IQueryable<Product> products = _db.Products;

            if (filter?.BrandId != null)
                products = products.Where(p => p.BrandId == filter.BrandId);

            if (filter?.CategoryId != null)
                products = products.Where(p => p.CategoryId == filter.CategoryId);

            return products;
        }
    }
}
