using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleaningServiceManagement.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal BasePrice { get; set; }

        [Required]
        public int DurationMinutes { get; set; }

        [Required]
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
