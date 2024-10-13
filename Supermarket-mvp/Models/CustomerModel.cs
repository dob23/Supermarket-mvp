using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Customer First Name")]
        [Required(ErrorMessage = "Customer First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer First Name must be between 3 and 50 Charaters")]
        public string First_Name { get; set; }

        [DisplayName("Customer Last Name")]
        [Required(ErrorMessage = "Customer Last Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer Last Name must be between 3 and 50 Charaters")]
        public string Last_Name { get; set; }

        [DisplayName("Customer Document")]
        [Required(ErrorMessage = "Customer Document is required")]
        [StringLength(15, ErrorMessage = "Customer Document must be 15 Charaters")]
        public string Document { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "Customer Address is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Customer Address must be between 3 and 80 Charaters")]
        public string Address { get; set; }

        [DisplayName("Customer Birthday")]
        [Required(ErrorMessage = "Customer Birthday is required")]
        public DateTime? Birthday { get; set; }

        [DisplayName("Customer Phone")]
        [Required(ErrorMessage = "Customer Phone is required")]
        [StringLength(16, ErrorMessage = "Customer Phone must be 16 Charaters")]
        public string Phone { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer Email is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customer Email must be between 3 and 100 Charaters")]
        public string Email { get; set; }

    }
}
