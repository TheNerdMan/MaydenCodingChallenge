using Mayden_Coding_Challenge.Controls;
using Mayden_Coding_Challenge.Models;
using Mayden_Coding_Challenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mayden_Coding_Challenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get list and pass to user control
            var srv = new ShoppingListController();
            List.shoppingList = srv.getShoppingList();

            // We use view state here to make sure that button clicks etc don't
            // lose the newly created control
            if (ViewState["addNewItem"] != null && (bool)ViewState["addNewItem"])
            {                
                var control = LoadControl(@"~\Controls\NewItem.ascx");
                newRecordPlaceholder.Controls.Add(control);
            }
        }

        // Create new control then display, also set view state to capture this incase of page refresh
        protected void addButton_Click(object sender, EventArgs e)
        {
            if (newRecordPlaceholder.Controls.Count <= 0)
            {
                var control = LoadControl(@"~\Controls\NewItem.ascx");
                newRecordPlaceholder.Controls.Add(control);
                ViewState["addNewItem"] = true;
                
            } else
            {
                newRecordPlaceholder.Controls.Clear();
                ViewState["addNewItem"] = false;
            }
        }
    }
}