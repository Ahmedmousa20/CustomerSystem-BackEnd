using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Interface
{
    public interface IUnitOfWork
    {
        public ICustomerRepo Customer { set; get; }
        public ICustomersAddressRepo CustomerAddress { get; set; }
    }
}
