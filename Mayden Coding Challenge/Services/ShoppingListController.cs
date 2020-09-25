using Mayden_Coding_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Mayden_Coding_Challenge.Services
{
    public class ShoppingListController
    {
        public List<ShoppingListItem> getShoppingList()
        {
            return new List<ShoppingListItem>() {
                new ShoppingListItem("test", 1, 1f),
                new ShoppingListItem("test 2", 2, 1f),
                new ShoppingListItem("test 3", 3, 1f),
                new ShoppingListItem("test 4", 4, 1f) 
            };
        }
    }
}