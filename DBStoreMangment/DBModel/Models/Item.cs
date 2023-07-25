using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string ItemName { get; set; }
        [Required,MaxLength(250)]
        public string ItemNumber { get; set; }
        [ForeignKey("Units")]
        public int UnitId { get; set; }
        public virtual Unit Units { get; set; }
        [ForeignKey("Departments")]
        public int DeptId { get; set; }
        public virtual Department Departments { get; set; }
        public virtual List<ItemStore> ItemStores { get; set; }
        public virtual List<ReceivingItem> ReceivingItems { get; set; }

    }
}
