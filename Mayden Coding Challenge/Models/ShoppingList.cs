using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mayden_Coding_Challenge.Models
{
    public class ShoppingListItem
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public float pricePerUnit { get; set; }
        public string imageUrl { get; set; }
        public int order { get; set; }
        public bool marked { get; set; } = false;

        public ShoppingListItem(string name, int quantity, float pricePerUnit, int order)
        {
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.imageUrl = "https://www.placecage.com/300/300";
            this.order = order;
        }
    }
}