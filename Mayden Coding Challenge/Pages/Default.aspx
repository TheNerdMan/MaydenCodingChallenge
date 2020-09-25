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
        <div class="row">
            <uc1:List runat="server" ID="List" />
        </div>
    </div>

</asp:Content>
