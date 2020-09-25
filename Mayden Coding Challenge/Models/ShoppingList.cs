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

        public ShoppingListItem(string name, int quantity, float pricePerUnit)
        {
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.imageUrl = "https://www.placecage.com/300/300";
        }
    }
}