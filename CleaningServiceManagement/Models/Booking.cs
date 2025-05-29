using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleaningServiceManagement.Models
{
    public enum BookingStatus { Pending, Confirmed, Completed, Cancelled }

    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public int ClientId { get; set; }
        public User Client { get; set; }

        [Required]
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalPrice { get; set; }

        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        [StringLength(1000)]
        public string SpecialRequests { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
