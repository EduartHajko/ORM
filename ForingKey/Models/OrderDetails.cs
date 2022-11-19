using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey.Models
{
  
    public class OrderDetails
    {
        [Key]
        public int DetailId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int Price { get; set; }
        public Orders orderss { get; set; }
    }
}
