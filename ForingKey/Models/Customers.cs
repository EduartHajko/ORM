using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey.Models
{
    
    public class Costumer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [Key]
        public int CostumerID { get; set; }
        public int Amount { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
