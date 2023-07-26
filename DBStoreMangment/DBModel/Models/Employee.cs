using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }

        private const int PhoneNumberLength = 11;

        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Employee phone must be numeric")]
        [StringLength(PhoneNumberLength, ErrorMessage = "Phone number must be {1} digits", MinimumLength = PhoneNumberLength)]
        public string EmployeePhone { get; set; }

        private const int NationalIdLength = 14;

        [Required(ErrorMessage = "Please enter your national ID")]
        [RegularExpression(@"^\d+$", ErrorMessage = "National ID must be numeric")]
        [StringLength(NationalIdLength, ErrorMessage = "National ID must be {1} digits", MinimumLength = NationalIdLength)]
        public string NationalID { get; set; }
    }
}
