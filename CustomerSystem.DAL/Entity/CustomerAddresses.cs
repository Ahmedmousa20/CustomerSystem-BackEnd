using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.DAL.Entity
{
    public class CustomerAddresses
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")] 
        public Customer Customer { get; set; }

        [Required]
        public string CustomerAddress { get; set; }


    }
}
