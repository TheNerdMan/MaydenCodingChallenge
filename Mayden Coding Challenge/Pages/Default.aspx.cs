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
        }

        protected void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}