using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string FirstName { get; set; }

        [Required, MaxLength(250)]
        public string LastName { get; set; }

        [Required]
        [StringLength(48, ErrorMessage = "Error In Encrypt Password")]
        public string HashPassword { get; set; }

        [Required, MaxLength(16)]
        public byte[] Salt { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        // Add a constructor to set the IsAdmin property to false by default
        public User()
        {
            IsAdmin = false;
        }
    }
}

