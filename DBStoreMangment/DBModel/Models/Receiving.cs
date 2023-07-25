using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Receiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ReceivingData { get; set; }
        [ForeignKey("Vendors")]
        public int VendorId { get; set; }
        public virtual Vendor Vendors { get; set; }
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual List<ReceivingItem> ReceivingItems { get; set; }
    }
}
