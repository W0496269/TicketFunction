using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFunction
{
    public class Ticket
        {
        [Required]
        public int ConcertId { get; set; } 

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, Phone]
        public string Phone { get; set; } = string.Empty;

        [Required, Range(1, 10)]
        public int Quantity { get; set; }

        [Required, CreditCard]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        public string Expiration { get; set; } // MM/YY format

        [Required, StringLength(3, MinimumLength = 3)] 
        public string SecurityCode { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } 

        [Required]
        public string City { get; set; } 

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }
    
    }
}
