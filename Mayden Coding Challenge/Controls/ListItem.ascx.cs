using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mayden_Coding_Challenge.Models;
using Mayden_Coding_Challenge.Services;

namespace Mayden_Coding_Challenge.Controls
{
    public partial class ListItem : System.Web.UI.UserControl
    {
        public ShoppingListItem item;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Don't bind if we are null, we do null checks on front end
            if (item != null)
            {
                DataBind();
                if (item.marked)
                {
                    itemDiv.Attributes.Add("class", "shoppingListItem row markedOff");
                }
            }
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            // Call our service to remove on click
            var srv = new ShoppingListController();
            srv.removeItem(item);
            Response.Redirect(Request.RawUrl);
        }

        protected void markButton_Click(object sender, EventArgs e)
        {
            // Call our service to remove on click
            var srv = new ShoppingListController();
            item.marked = !item.marked;
            srv.updateItem(item.id, item);
            Response.Redirect(Request.RawUrl);
        }
    }
}