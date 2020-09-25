<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mayden_Coding_Challenge._Default" %>

<%@ Register Src="~/Controls/List.ascx" TagPrefix="uc1" TagName="List" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <h1 class="col-md-6">Shopping List</h1>
            <div class="col-md-2">
                <asp:Button runat="server" ID="addButton" Text="+" CssClass="addButton" OnClick="addButton_Click" />
            </div>
        </div>
        <div class="row header">
            <h3 class="title col-md-5">Name</h3>
            <h3 class="quantity col-md-2">Quantity</h3>
            <h3 class="cost col-md-1">Price</h3>
            <h3 class="col-md-2">Image</h3>
            <h3 class="col-md-2">Actions</h3>
        </div>
        <div class="row">
            <asp:PlaceHolder runat="server" ID="newRecordPlaceholder"></asp:PlaceHolder>
        </div>
        <div class="row">
            <uc1:List runat="server" ID="List" />
        </div>
    </div>

</asp:Content>
