using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMyRide.Shared
{
    public class Car
    {
        public int Id { get; set; }
        public string? VIN { get; set; }
        public string? LicensePlate { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public Custom? Custom { get; set; }
        public int? CustomId { get; set; }
    }
}
