<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageForAdmin.master" AutoEventWireup="true" CodeFile="BookInventory.aspx.cs" Inherits="Admin_BookInventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/HomePage_StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">
     <div>
        <table>
            <tr>
                 <td><asp:CheckBox ID="chkSearch" runat="server" /><asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label></td>
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
            <td><asp:Button ID="btnSearch" CssClass="button" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
            <td><asp:Button ID="btnReset" CssClass="button" runat="server" Text="Reset" OnClick="btnReset_Click"  /></td>
        </tr>        
        </table><br />
        <asp:GridView ID="GridViewResult" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" 
            DataKeyNames="BookID"
            OnRowDataBound="OnRowDataBound"
            OnRowEditing="OnRowEditing" 
            OnRowUpdating="OnRowUpdating"
            OnRowCancelingEdit="OnRowCancelingEdit"
             >
            <Columns>

                <asp:TemplateField HeaderText="ISBN" SortExpression="ISBN">
                    <ItemTemplate>
                        <asp:Label ID="lbISBN" runat="server" Text='<%# Bind("ISBN") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="BookTitle" SortExpression="BookTitle">
                    <ItemTemplate>
                        <asp:Label ID="lbBookTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Author" SortExpression="Author">
                    <ItemTemplate>
                        <asp:Label ID="lbAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock" SortExpression="Stock">
                    <ItemTemplate>
                        <asp:Label ID="lbStock" runat="server" Text='<%# Bind("Stock") %>'></asp:Label>
                    </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="tbEditStock" runat="server" Text='<%# Bind("Stock") %>'></asp:TextBox>                  
                    </EditItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Discount" SortExpression="Discount">
                    <ItemTemplate>
                        <asp:Label ID="lbDiscount" runat="server" Text='<%# Bind("Discount") %>'></asp:Label>
                    </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="tbEditDiscount" runat="server" Text='<%# Bind("Discount") %>'></asp:TextBox>                  
                    </EditItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>


    </div>
  </div>
</asp:Content>

