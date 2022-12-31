using CustomerSystem.BL.Interface;
using CustomerSystem.DAL.Database;
using CustomerSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Repository
{
    public class CustomersAddressRepo : ICustomersAddressRepo
    {

        private readonly DemoContext db;

        public CustomersAddressRepo(DemoContext db)
        {
            this.db = db;
        }

        private IEnumerable<CustomerAddresses> GetCustomersAddress()
        {
            return db.CustomersAddress.Include("Customer").Select(a => a);
        }

        public IEnumerable<CustomerAddresses> Get()
        {
            var data = GetCustomersAddress();
            return data;
        }

        public CustomerAddresses GetById(int id)
        {
            var data = db.CustomersAddress.Where(a => a.CustomerId == id).FirstOrDefault();
            return data;
        }

        public void Create(CustomerAddresses obj)
        {
            db.CustomersAddress.Add(obj);
            db.SaveChanges();

        }

        public void Edit(CustomerAddresses obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(CustomerAddresses obj)
        {
            db.CustomersAddress.Remove(obj);
            db.SaveChanges();
        }




    }
}
