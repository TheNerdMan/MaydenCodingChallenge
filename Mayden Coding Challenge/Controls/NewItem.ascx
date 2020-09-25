<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewItem.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.NewItem" %>

<div class="shoppingListItem row new">
    <div class="col-md-4">
        <asp:TextBox runat="server" ID="newItemName" CssClass="title"></asp:TextBox>
    </div>
    <div class="col-md-2">
        <asp:TextBox runat="server" ID="newItemQuantity" CssClass="quantity"></asp:TextBox>
    </div>
    <div class="col-md-2">
        <asp:TextBox runat="server" ID="newItemCost" CssClass="cost"></asp:TextBox>   
    </div> 
    <div class="col-md-2">
        <asp:TextBox runat="server" ID="newItemImageLink" CssClass="cost"></asp:TextBox>
    </div>
    <div class="save col-md-2">
        <asp:LinkButton runat="server" ID="saveNewItemButton" Text="Save" CssClass="saveNewItemButton" />
    </div>
</div>
<div class="row">
    <p class="errorMessage" runat="server" id="errorMessage"></p>
</div>