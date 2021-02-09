using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    [Table("Brands")]
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
