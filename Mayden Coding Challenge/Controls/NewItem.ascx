<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewItem.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.NewItem" %>

<div class="shoppingListItem row">
    <asp:TextBox runat="server" ID="newItemName" CssClass="title col-md-6"></asp:TextBox>
    <asp:TextBox runat="server" ID="newItemQuantity" CssClass="quantity col-md-6"></asp:TextBox>
    <h3 class="cost col-md-1"></h3>
    <asp:Image runat="server" ImageUrl="" CssClass="image col-md-2" />
    <div class="save col-md-1">
        <asp:Button runat="server" ID="saveNewItemButton" CssClass="saveNewItemButton" OnClick="saveNewItemButton_Click" />
    </div>
</div>