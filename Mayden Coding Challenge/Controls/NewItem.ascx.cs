using Mayden_Coding_Challenge.Models;
using Mayden_Coding_Challenge.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (ValidateNewItem())
            {
                // save user entered values
                var name = newItemName.Text ?? "";
                var quantity = int.TryParse(newItemQuantity.Text, out var o) ? o : 0;
                var pricePerUnit = int.TryParse(newItemQuantity.Text, out var u) ? u : 0;
                var imageUrl = newItemImageLink.Text ?? "https://www.placecage.com/300/300";

                // TO:DO lookup other values from API
                // item.cost = getCost(item.name);
                // item.image = getImage(item.image);

                // push to list
                var srv = new ShoppingListController();
                srv.addItem(new ShoppingListItem(name, quantity, pricePerUnit, imageUrl, 0));
                Response.Redirect(Request.RawUrl);
            }
        }

        private bool ValidateNewItem()
        {
            errorMessage.InnerText = "";
            var allValid = true;
            // Name Validation
            if(string.IsNullOrWhiteSpace(newItemName.Text) || !newItemName.Text.All(char.IsLetterOrDigit))
            {
                errorMessage.InnerText += "Name should be alphanumeric. ";
                allValid = false;
            }

            // Quantity
            if (string.IsNullOrWhiteSpace(newItemQuantity.Text) || !newItemQuantity.Text.All(char.IsDigit))
            {
                errorMessage.InnerText += "Quantity should be numeric. ";
                allValid = false;
            }

            // Price
            var style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            var culture = CultureInfo.CreateSpecificCulture("en-GB");
            if (string.IsNullOrWhiteSpace(newItemCost.Text) || !Decimal.TryParse(newItemCost.Text.Trim(), style, culture, out var v))
            {
                errorMessage.InnerText += "Price should be in £ and only numbers. ";
                allValid = false;
            }

            // Image
            Uri uriResult;
            bool result = Uri.TryCreate(newItemImageLink.Text, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;
            if (result)
            {
                errorMessage.InnerText += "Image should be a valid URL. ";
                allValid = false;
            }

            return allValid;
        }
    }
}