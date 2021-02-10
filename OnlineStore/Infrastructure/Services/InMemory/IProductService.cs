using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;
using OnlineStore.Data;

namespace OnlineStore.Infrastructure.Services.InMemory
{
    public class IProductService : IProduct
    {
        public IEnumerable<Brand> GetBrands()
        {
            return TestData.Brands;
        }

        public IEnumerable<Category> GetCategories()
        {
            return TestData.Categories;
        }

        public IEnumerable<Product> GetProducts(Filter filter = null)
        {
            var products = TestData.Products;

            if (filter?.BrandId != null)
                products = products.Where(p => p.BrandId == filter.BrandId);

            if (filter?.CategoryId != null)
                products = products.Where(p => p.CategoryId == filter.CategoryId);

            return products;
        }
    }
}
