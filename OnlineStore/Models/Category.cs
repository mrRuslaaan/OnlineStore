﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        string Name { get; set; }
        public int? ParentId { get; set; }
    }
}