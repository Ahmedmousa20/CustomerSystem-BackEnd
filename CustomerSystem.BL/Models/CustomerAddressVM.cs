using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Models
{
    public class CustomerAddressVM
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [RegularExpression("[0-9]{2,5}-[a-zA-Z]{2,5}-[a-zA-Z]{2,5}-[a-zA-Z]{2,5}")]
        [StringLength(50)]
        public string CustomerAddress { get; set; }
    }
}
