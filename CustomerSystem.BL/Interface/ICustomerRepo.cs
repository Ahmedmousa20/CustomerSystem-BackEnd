using CustomerSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Interface
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> Get();
        Customer GetById(int id);
        void Create(Customer obj);
        void Edit(Customer obj);
        void Delete(Customer obj);
    }
}
