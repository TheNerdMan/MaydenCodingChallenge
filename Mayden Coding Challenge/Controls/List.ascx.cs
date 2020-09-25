using Mayden_Coding_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mayden_Coding_Challenge.Controls
{
    public partial class List : System.Web.UI.UserControl
    {
        public List<ShoppingListItem> shoppingList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            // bind list
            ShoppingList.DataSource = shoppingList.OrderBy(c => c.order).ThenBy(c => c.marked);
            DataBind();
        }

        protected void ShoppingList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            // get each item then bind to listItem control
            ListItem ucItem = (ListItem)e.Item.FindControl("ucListItem");
            ucItem.item = (ShoppingListItem)e.Item.DataItem;
            ucItem.DataBind();
        }

    }
}