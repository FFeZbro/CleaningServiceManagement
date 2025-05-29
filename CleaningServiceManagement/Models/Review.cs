using System;
using System.ComponentModel.DataAnnotations;

namespace CleaningServiceManagement.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }

        [Required]
        public int ClientId { get; set; }
        public User Client { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        public bool IsApproved { get; set; } = false;
    }
}
