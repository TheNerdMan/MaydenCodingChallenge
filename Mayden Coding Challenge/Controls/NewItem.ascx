<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewItem.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.NewItem" %>

<div class="shoppingListItem row new">
    <asp:TextBox runat="server" ID="newItemName" CssClass="title col-md-6"></asp:TextBox>
    <asp:TextBox runat="server" ID="newItemQuantity" CssClass="quantity col-md-1"></asp:TextBox>
    <asp:TextBox runat="server" ID="newItemCost" CssClass="cost col-md-1"></asp:TextBox>    
    <asp:TextBox runat="server" ID="newItemImageLink" CssClass="cost col-md-1"></asp:TextBox>
    <div class="save col-md-1">
        <asp:Button runat="server" ID="saveNewItemButton" CssClass="saveNewItemButton" />
    </div>
</div>