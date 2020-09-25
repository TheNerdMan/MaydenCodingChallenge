using Mayden_Coding_Challenge.Models;
using Mayden_Coding_Challenge.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mayden_Coding_Challenge.Controls
{
    public partial class NewItem : System.Web.UI.UserControl
    {
        public ShoppingListItem item = new ShoppingListItem("", 0, 0, 0);

        protected void Page_Load(object sender, EventArgs e)        
        {
            saveNewItemButton.Click += saveNewItemButton_Click;
        }

        protected void saveNewItemButton_Click(object sender, EventArgs e)
        {
            // save user entered values
            item.name = newItemName.Text ?? "";
            item.quantity = int.TryParse(newItemQuantity.Text, out var o) ? o : 0;
            item.pricePerUnit = int.TryParse(newItemQuantity.Text, out var u) ? u : 0;
            item.imageUrl = newItemImageLink.Text ?? "";

            // TO:DO lookup other values from API
            // item.cost = getCost(item.name);
            // item.image = getImage(item.image);

            // push to list
            var srv = new ShoppingListController();
            srv.addItem(item);
            Response.Redirect(Request.RawUrl);
        }
    }
}