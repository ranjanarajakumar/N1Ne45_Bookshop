<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DefaultSearch.aspx.cs" Inherits="DefaultSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="css/HomePage_StyleSheet.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">  
        <div id="header">
            <h1>N1Ne45 BookShop</h1>
        </div>
        <div class="center">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button CssClass="button" ID="Button1" runat="server" Text="Search" />
        </div>
        <div>
            <asp:GridView ID="GridViewResult" runat="server"></asp:GridView>
        </div>
  </div>
</asp:Content>

