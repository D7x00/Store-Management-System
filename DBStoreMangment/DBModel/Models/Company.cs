using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string CompanyName { get; set; }

        [MaxLength(250)]
        public string? CompanyLocation { get; set; }

        public string? Description { get; set; }
    }
}
