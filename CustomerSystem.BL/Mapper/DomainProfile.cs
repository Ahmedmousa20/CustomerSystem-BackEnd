using AutoMapper;
using CustomerSystem.BL.Models;
using CustomerSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Mapper
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<Customer, CustomerVM>();
            CreateMap<CustomerVM, Customer>();

            CreateMap<CustomerAddresses, CustomerAddressVM>();
            CreateMap<CustomerAddressVM, CustomerAddresses>();
        }

    }
}
