using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class Receiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReceivingDate { get; set; }

        [ForeignKey("Vendors")]
        public int VendorId { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }

        public virtual List<ReceivingItem> ReceivingItems { get; set; }

        // Additional code for security and correctness
        [ForeignKey("VendorId")]
        public virtual Vendor Vendors { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employees { get; set; }
    }
}
