<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListItem.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.ListItem" %>

<div class="shoppingListItem row" runat="server" id="itemDiv">
    <h1 class="title col-md-5"><%# (item == null) ? "null" : item.name%></h1>
    <h2 class="quantity col-md-2"><%# (item == null) ? 0 : item.quantity %></h2>
    <h3 class="cost col-md-2"><%# (item == null) ? 0.ToString("C") : item.pricePerUnit.ToString("C")%></h3>
    <asp:Image runat="server" ImageUrl='<%# (item == null) ? "" : item.imageUrl %>' CssClass="image col-md-2" />
    <div class="col-md-1">
        <asp:LinkButton runat="server" ID="markButton" Text="Mark Off" CssClass="markButton" OnClick="markButton_Click"/>
        <asp:LinkButton runat="server" ID="removeButton" Text="Remove" CssClass="removeButton" OnClick="removeButton_Click"/>
    </div>
    <div class="moveButton col-md-1"></div>
</div>