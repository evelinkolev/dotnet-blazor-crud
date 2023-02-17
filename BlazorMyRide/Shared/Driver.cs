using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMyRide.Shared
{
    public class Driver
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? NationalCardNumber { get; set; }
        public string? PIN { get; set; }
        public int? CarId { get; set; }
        public Car? Cars { get; set; }
    }
}
