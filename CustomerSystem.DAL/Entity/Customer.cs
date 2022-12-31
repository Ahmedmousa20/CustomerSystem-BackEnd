using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.DAL.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerFirstName { get; set; }

        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [StringLength(1)]
        public string CustomerGender { get; set; }

        [Required]
        public DateTime CustomerDOB { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }
        public ICollection<CustomerAddresses> CustomerAddress { get; set; }
    }
}
