﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class About
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Text { get; set; }
        public string? Description { get; set; }
    }
}
