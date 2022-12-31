using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem.BL.Models
{
    public class CustomerVM
    {

        public int CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerFirstName { get; set; }

        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [StringLength(50)]
        public string CustomerGender { get; set; }

        [Required]
        public DateTime CustomerDOB { get; set; }

        [EmailAddress(ErrorMessage = "Mail Invalid")]
        public string CustomerEmail { get; set; }
    }
}
