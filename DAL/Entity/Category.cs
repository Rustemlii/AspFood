﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Menu>? Menus { get; set; }

    }
}
