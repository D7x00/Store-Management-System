﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class IssuingItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Issuings")]
        public int IssuingId { get; set; }
        public virtual Issuing Issuings { get; set; }

        [ForeignKey("Items")]
        public int ItemId { get; set; }
        public virtual Item Items { get; set; }

        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public virtual Store Stores { get; set; }
    }
}
