﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public Guid ProductFK { get; set; }
        public virtual Product Product { get; set; }
        
        [ForeignKey("Order")]
        public Guid OrderFK { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
