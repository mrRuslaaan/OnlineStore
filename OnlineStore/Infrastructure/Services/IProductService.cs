using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;
using OnlineStore.Data;

namespace OnlineStore.Infrastructure.Services
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
    }
}
