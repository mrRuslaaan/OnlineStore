using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public DateTime DateOfPublication { get; set; }
    }
}
