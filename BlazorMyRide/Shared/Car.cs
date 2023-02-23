using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMyRide.Shared
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "VIN is required")]
        [StringLength(20)]
        public string? VIN { get; set; }

        [Required(ErrorMessage = "License Plate is required")]
        [StringLength(30, MinimumLength = 4)]
        public string? LicensePlate { get; set; }

        [Required(ErrorMessage = "Make is required")]
        [StringLength(50, MinimumLength = 2)]
        public string? Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [StringLength(50, MinimumLength = 2)]
        public string? Model { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [StringLength(30, MinimumLength = 2)]
        public string? Color { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Custom? Custom { get; set; }
        public int? CustomId { get; set; }
    }
}
