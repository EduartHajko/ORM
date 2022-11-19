using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey.Models
{
  
    public class OrderDetails: BaseClass
    {

        public int Price { get; set; }
        public Orders orderss { get; set; }
    }
}
