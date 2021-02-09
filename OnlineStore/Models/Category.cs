using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public ICollection<Product> Products { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Category ParentCategory { get; set; }
    }
}
