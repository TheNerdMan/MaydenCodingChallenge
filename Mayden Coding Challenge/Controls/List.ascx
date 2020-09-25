<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="List.ascx.cs" Inherits="Mayden_Coding_Challenge.Controls.List" %>
<%@ Register Src="~/Controls/ListItem.ascx" TagPrefix="uc1" TagName="ListItem" %>


<div class="">
    <asp:Repeater runat="server" ID="ShoppingList" OnItemDataBound="ShoppingList_ItemDataBound">
        <ItemTemplate>
            <uc1:ListItem runat="server" ID="ucListItem"/>
        </ItemTemplate>
    </asp:Repeater>
</div>