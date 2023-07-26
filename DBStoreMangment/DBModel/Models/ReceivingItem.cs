using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class ReceivingItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Receivings")]
        public int ReceivingId { get; set; }
        public virtual Receiving Receivings { get; set; }

        [ForeignKey("Items")]
        public int ItemId { get; set; }
        public virtual Item Items { get; set; }

        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public virtual Store Stores { get; set; }
    }
}
