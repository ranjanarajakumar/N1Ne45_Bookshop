<%@ Page Title="" Language="C#" MasterPageFile="~/RegisteredUsers/MasterPageForUsers.master" AutoEventWireup="true" CodeFile="AdvanceSearch.aspx.cs" Inherits="RegisteredUsers_AdvanceSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/HomePage_StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">  
        <div id="header">
            <h1>N1Ne45 BookShop</h1>
        </div>
    <div>
        <table>
            <tr>
                 <td><asp:CheckBox ID="chkSearch" runat="server"/><asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label></td>
                 <td><asp:TextBox ID="txtSearch" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:CheckBox ID="chkAuthor" runat="server" /><asp:Label ID="lblAutor" runat="server" Text="Author"></asp:Label></td>
                <td><asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox></td>
             </tr>
            <tr>
                <td><asp:CheckBox ID="ChkCategory" runat="server" /><asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownListCategory" runat="server" Width="102px">
                        <asp:ListItem Value="1">Children</asp:ListItem>
                        <asp:ListItem Value="2">Finance</asp:ListItem>
                        <asp:ListItem Value="3">Non-fiction</asp:ListItem>
                        <asp:ListItem Value="4">Technical</asp:ListItem>
                    </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSearch" CssClass="button" runat="server" Text="Search" OnClick="btnSearch_Click"/></td>
            <td><asp:Button ID="btnReset" CssClass="button" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
        </tr>        
        </table><br />
        <asp:GridView ID="GridViewResult" runat="server" AutoGenerateSelectButton="True" DataKeyNames="BookID" OnSelectedIndexChanged="GridViewResult_SelectedIndexChanged"></asp:GridView><br/>
        <asp:Button ID="AddCartButton" runat="server" Text="Check the Cart" OnClick="AddCartButton_Click" />

    </div>
  </div>
</asp:Content>

