using Mayden_Coding_Challenge.Models;
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
        public ShoppingListItem item;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveNewItemButton_Click(object sender, EventArgs e)
        {
            // save user entered values
            item.name = newItemName.Text;
            item.quantity = int.TryParse(newItemQuantity.Text, out var o) ? o : 0;

            // lookup other values
            // item.cost = getCost(item.name);
            // item.image = getImage(item.image);

            // push to list

        }
    }
}