using CustomerSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.DAL.Database
{
    public class DemoContext : DbContext
    {
        public DbSet<Customer> Customer { set; get; }
        public DbSet<CustomerAddresses> CustomersAddress { set; get; }
        public DemoContext(DbContextOptions<DemoContext> opt) : base(opt)
        {

        }
    }
}
