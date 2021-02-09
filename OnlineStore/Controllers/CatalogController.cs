using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.Models;
using OnlineStore.ViewModel;

namespace OnlineStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProduct _Products;

        public CatalogController(IProduct Products) => _Products = Products;
        public IActionResult Index(int? CategoryID, int? BrandID)
        {
            var filter = new Filter
            {
                CategoryId = CategoryID,
                BrandId = BrandID,
            };

            var products = _Products.GetProducts(filter);

            var catalog = new CatalogViewModel
            {
                BrandID = BrandID,
                CategoryID = CategoryID,
                Products = products
                        .Select(p => new ProductViewModel
                        {
                            Id = p.Id,
                            Name = p.Name,
                            CategoryId = p.CategoryId,
                            BrandId = p.BrandId,
                            ImageUrl = p.ImageUrl,
                            Price = p.Price,
                        })
            };

            return View(catalog);
        }
    }
}
