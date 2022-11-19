using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForingKey
{
    public class CustomerContext : DbContext
    {
        public DbSet<Models.Costumer> Customers { get; set; }
        public DbSet<Models.Orders> Orders { get; set; }
        public DbSet<Models.OrderDetails> OrdersDetails { get; set; }
        public DbSet<Models.Logs> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CustomerDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
