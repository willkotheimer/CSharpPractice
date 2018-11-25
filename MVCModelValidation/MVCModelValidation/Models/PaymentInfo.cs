using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCModelValidation.Models
{
    public class PaymentInfo
    {
        [Required]
        [StringLength(80, MinimumLength=5)]
        public string Name { get; set; }

        [Required]
        [CreditCard]
        public string CardNumber { get; set; }

        [Required]
        [Range(1,12)]
        public int ExpiresMonth { get; set; }

        [Required]
        [Range(2017,2036)]
        public int ExpiresYear { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
