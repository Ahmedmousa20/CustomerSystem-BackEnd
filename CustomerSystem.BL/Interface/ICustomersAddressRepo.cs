using CustomerSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Interface
{
    public interface ICustomersAddressRepo 
    {
        IEnumerable<CustomerAddresses> Get();
        CustomerAddresses GetById(int id);
        void Create(CustomerAddresses obj);
        void Edit(CustomerAddresses obj);
        public void Delete(CustomerAddresses obj);
    }
}
