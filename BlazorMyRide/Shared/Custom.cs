using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMyRide.Shared
{
    public class Custom
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(150)]
        public string Description { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        [Range(20, 10000, ErrorMessage = "The Price must be between $20 and $10000 (incl. VAT)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
