using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class Vendor
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

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Number Must Be 11 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Vendor phone must be numeric")]
        [Required]
        public string vendorPhone { get; set; }

        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID Must Be 14 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "National ID must be numeric")]
        [Required(ErrorMessage = "Please Enter Your National Id")]
        public string NationalID { get; set; }
        [ForeignKey("Companys")]
        public int CompanyId { get; set; }
        public virtual Company Companys { get; set; }
    }
}
