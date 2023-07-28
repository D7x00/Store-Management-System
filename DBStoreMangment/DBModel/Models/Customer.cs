using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(500)]
        public string Name { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Number Must Be 11 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Customer phone must be numeric")]
        [Required]
        public string CustomerPhone { get; set; }

        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID Must Be 14 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "National ID must be numeric")]
        [Required(ErrorMessage = "Please Enter Your National Id")]
        public string NationalID { get; set; }
        public virtual List<Issuing> Issuings { get; set; }
    }
}
