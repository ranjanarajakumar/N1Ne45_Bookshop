<%@ Page Title="" Language="C#" MasterPageFile="~/RegisteredUsers/MasterPageForUsers.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="RegisteredUsers_Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowUpdating="GridView1_RowUpdating" OnRowEditing="GridView1_RowEditing">
                <Columns>
 
             
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowEditButton="True" />
 
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
</asp:Content>

