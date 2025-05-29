using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleaningServiceManagement.Models
{
    public class Provider
    {
        [Key]
        public int ProviderId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(20)]
        public string TaxId { get; set; }

        [Range(0, 100)]
        public float Rating { get; set; }

        public List<Service> Services { get; set; } = new List<Service>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
