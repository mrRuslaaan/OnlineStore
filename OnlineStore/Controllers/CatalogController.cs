using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProduct _Products;

        public CatalogController(IProduct Products) => _Products = Products;
        public IActionResult Index()
        {
            var products = _Products.GetProducts();

            return View(products);
        }
    }
}
