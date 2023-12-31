﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModel.Models
{
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string StoreName { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Number Must Be 11 Numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Store phone must be numeric")]
        public string? StorePhone { get; set; }
        public List<ItemStore> ItemStores { get; set; }
        public virtual List<ReceivingItem> ReceivingItems { get; set; }
        public virtual List<IssuingItem> IssuingItems { get; set; }
    }
}
