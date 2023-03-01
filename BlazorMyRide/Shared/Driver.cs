using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMyRide.Shared
{
    public class Driver
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50)]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(50)]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(20)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(80)]
        public string? Address { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "National ID is required")]
        [StringLength(50)]
        public string? NationalCardNumber { get; set; }

        [Required(ErrorMessage = "PIN is required")]
        [StringLength(20)]
        public string? PIN { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? CarId { get; set; }
        public Car? Car { get; set; }
    }
}
