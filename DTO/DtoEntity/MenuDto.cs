﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DtoEntity
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }
        public int? DisCount { get; set; }
        public int? Gram { get; set; }
        public int? Calory { get; set; }
        public DateTime? Date { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public virtual Category? Category { get; set; }
    }
}
