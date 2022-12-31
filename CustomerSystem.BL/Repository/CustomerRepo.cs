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
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DemoContext db;

        public CustomerRepo(DemoContext db)
        {
            this.db = db;
        }

        public IEnumerable<Customer> Get()
        {
            var data = db.Customer.Select(a => a);
            return data;
        }

        public Customer GetById(int id)
        {
            var data = db.Customer.Where(a => a.CustomerId == id).FirstOrDefault();
            return data;
        }

        public void Create(Customer obj)
        {
            db.Customer.Add(obj);
            db.SaveChanges();

        }

        public void Edit(Customer obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Customer obj)
        {
            db.Customer.Remove(obj);
            db.SaveChanges();
        }

    }
}