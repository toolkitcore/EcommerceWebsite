﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ShopApplication.Infrastructure.SharedKernels;

namespace ShopApplication.Data.Entities
{
    [Table("WholePrices")]
    public class WholePrice : DomainEntity<int>
    {

        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
