﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DtoEntity
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
