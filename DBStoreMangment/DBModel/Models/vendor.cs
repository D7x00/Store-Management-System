using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(250)]
        public string FirstName { get; set; }
        [Required, MaxLength(250)]
        public string LastName { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Number Must Be 11 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "must be numeric")]
        [Required]
        public string vendorPhone { get; set; }
        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID Must Be 14 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "must be numeric")]
        [Required(ErrorMessage = "Please Enter Your National Id")]
        public string NationalID { get; set; }
    }
}
