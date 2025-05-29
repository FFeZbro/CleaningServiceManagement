using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleaningServiceManagement.Models
{
    public enum UserRole { Client, Provider, Admin }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Index(IsUnique = true)]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(64)] // Для хэша SHA-256
        public string PasswordHash { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
