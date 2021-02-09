using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Models;

namespace OnlineStore.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<CategoryViewModel> ChildCategories { get; set; } = new List<CategoryViewModel>();
        public CategoryViewModel ParentCategory { get; set; }
    }
}
