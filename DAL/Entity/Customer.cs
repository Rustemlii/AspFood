using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Customer 
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? FirstName { get; set; }
        public string? lastName { get; set; }
        public string? Text { get; set; }
        public string? Rate { get; set; }
        public virtual List<Message>? Messages { get; set; }
    }
}
