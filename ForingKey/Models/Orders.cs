using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey.Models
{
   
    public class Orders
    {
        public string OrderName { get; set; }
        public string Address { get; set; }
        [Key]
        public string OrderId { get; set; }
        public string Destination { get; set; }
        public Costumer costumer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
