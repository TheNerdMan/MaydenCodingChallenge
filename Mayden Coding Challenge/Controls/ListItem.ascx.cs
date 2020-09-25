using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mayden_Coding_Challenge.Models;

namespace Mayden_Coding_Challenge.Controls
{
    public partial class ListItem : System.Web.UI.UserControl
    {
        public ShoppingListItem item;

        protected void Page_Init(object sender, EventArgs e)
        {
            // Don't bind if we are null, we do null checks on front end
            if (item != null)
            {
                DataBind();
            }
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}