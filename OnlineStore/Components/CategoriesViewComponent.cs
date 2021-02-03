using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Infrastructure.Interfaces;
using OnlineStore.ViewModel;

namespace OnlineStore.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly IProduct _Products;

        public CategoriesViewComponent(IProduct Products) => _Products = Products;

        public IViewComponentResult Invoke()
        {
            var categories = _Products.GetCategories().ToArray();

            var parent_categories = categories.Where(c => c.ParentId is null);

            var parent_categories_views = parent_categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();

            foreach (var parent_category in parent_categories_views)
            {
                var child_categories = categories.Where(c => c.ParentId == parent_category.Id);

                foreach (var child in child_categories)
                {
                    parent_category.ChildCategories.Add(new CategoryViewModel
                    {
                        Id = child.Id,
                        Name = child.Name,
                        ParentId = parent_category.Id,
                        ParentCategory = parent_category,
                    });
                }

            }

            return View(parent_categories_views);


        }
    }
}
