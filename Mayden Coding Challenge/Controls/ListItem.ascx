<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListItem.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.ListItem" %>

<div class="shoppingListItem row">
    <h1 class="title col-md-6"><%# (item == null) ? "null" : item.name%></h1>
    <h2 class="quantity col-md-1"><%# (item == null) ? 0 : item.quantity %></h2>
    <h3 class="cost col-md-1"><%# (item == null) ? 0.00f.ToString() : "£ " + item.pricePerUnit.ToString()%></h3>
    <asp:Image runat="server" ImageUrl='<%# (item == null) ? "" : item.imageUrl %>' CssClass="image col-md-2" />
    <div class="col-md-1">
        <asp:Button runat="server" ID="removeButton" Text="-" CssClass="removeButton" OnClick="removeButton_Click" />
    </div>
    <div class="moveButton col-md-1"></div>
</div>