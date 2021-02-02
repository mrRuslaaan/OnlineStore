using OnlineStore.Models;
using System.Collections.Generic;

namespace OnlineStore.Infrastructure.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Brand> GetBrands();

        IEnumerable<Category> GetCategories();

    }
}
