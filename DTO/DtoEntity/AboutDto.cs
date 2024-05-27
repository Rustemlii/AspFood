using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DtoEntity
{
    public class AboutDto
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Text { get; set; }
        public string? Description { get; set; }
    }
}