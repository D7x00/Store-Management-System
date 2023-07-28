using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Issuing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime IssuingDate { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public virtual Customer Customers { get; set; }
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual List<IssuingItem> IssuingItems { get; set; }

    }
}
