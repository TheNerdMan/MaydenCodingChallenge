﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mayden_Coding_Challenge.Models
{
    public class ShoppingListItem
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal pricePerUnit { get; set; }
        public string imageUrl { get; set; }
        public int order { get; set; }
        public bool marked { get; set; } = false;

        public ShoppingListItem(string name, int quantity, decimal pricePerUnit, string imageUrl,int order)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.imageUrl = imageUrl;
            this.order = order;
        }
    }
}