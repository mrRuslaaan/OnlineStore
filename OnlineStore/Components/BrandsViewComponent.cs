using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.ViewModel;

namespace OnlineStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProduct _Products;
        public BrandsViewComponent(IProduct Products) => _Products = Products;

        public IViewComponentResult Invoke()
        {
            var brands = _Products.GetBrands();

            var pr = _Products.GetProducts();

            var brandsEnum = brands.Select(brand => new BrandViewModel
            {
                Id = brand.Id,
                Name = brand.Name,
                AmoutOfProducts = pr
                .Where(p => brand.Id == p.BrandId)
                .Count(),
            });           

            return View(brandsEnum.OrderByDescending(b => b.AmoutOfProducts));
        }
    }
}
