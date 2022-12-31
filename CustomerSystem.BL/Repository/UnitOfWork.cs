using CustomerSystem.BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICustomerRepo Customer { get; set; }
        public ICustomersAddressRepo CustomerAddress { get; set; }

        public UnitOfWork(ICustomerRepo customerRepo , ICustomersAddressRepo customersAddressRepo)
        {
            Customer = customerRepo;
            CustomerAddress = customersAddressRepo;
        }
    }
}
