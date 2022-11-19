using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey.Models
{
    public class Logs
    {
        [Key]
        public int LogID { get; set; } 
        public string  ExceptionName { get; set; }

        public DateTime DateCreated { get; set; }= DateTime.Now;    
    }
}
