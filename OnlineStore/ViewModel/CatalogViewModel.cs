using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewModel
{
    public class CatalogViewModel
    {
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; } 
    }
}
