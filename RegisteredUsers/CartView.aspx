<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageForAdmin.master" AutoEventWireup="true" CodeFile="CartView.aspx.cs" Inherits="RegisteredUsers_CartView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style>
            table#t01 {
    width: 100%;    
    border: 1px solid black;
}
    th, td {
    padding: 5px;
    text-align: left;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>Welcome to the ViewCart Page<br />
        <asp:Repeater ID="Repeater1" runat="server" ItemType="Book" OnItemCommand="Repeater1_ItemCommand">
                      <ItemTemplate>
                          <table id ="t01">
                              <tr><td>Item No.</td><td>Details</td><td>Unit Price/Quantity</td><td>Total Price</td></tr>
          <tr>
              <td>
                <asp:Label runat="server" ID="Label1" Text='<%# Item.BookID %>'/>   
              </td>
              <td><table>
                  <tr>
              <td>
                  <asp:Label ID="Label10" runat="server" Text="Book ID: "></asp:Label><asp:Label runat="server" ID="Label8" Text='<%# Item.BookID %>'/>
              </td></tr>
                  <tr><td>
                      <asp:Label ID="Label11" runat="server" Text="Title: "></asp:Label><asp:Label runat="server" ID="Label2" Text='<%# Item.Title %>'/>
                      </td></tr>
                                <tr><td>
                                    <asp:Label ID="Label12" runat="server" Text="ISBN: "></asp:Label><asp:Label runat="server" ID="Label4" Text='<%# Item.ISBN %>'/>
              </td></tr></td></table>
                                <td><asp:Label ID="Label5" runat="server" Text='<%# Item.Price %>'></asp:Label><asp:Label ID="Label6" runat="server" Text="/"></asp:Label>
                  <asp:TextBox ID="TextBox1" runat="server" Width="20px" Enabled ="false" Text='<%# 1 %>'></asp:TextBox>
                                    <table><tr>
                                    <asp:Button ID="IncreaseQty" runat="server" Text="^" ItemCommand ="Increase"></asp:Button></tr><tr>
                                        <asp:Button ID="DecreaseQty" runat="server" Text="˅" />
                                                                                                       </tr>
                                        </table>
              </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="$"></asp:Label><asp:Label runat="server" ID="Label7" Text='<%# Item.Price %>' />
              </td>
              <td>
                  <asp:Button ID="RemoveFromCart" runat="server" Text="Remove from Cart" ItemCommand ="Delete"/>
              </td>
              </td>
          </tr>
                              </table>
          </ItemTemplate>
        </asp:Repeater>
    
        <asp:Label ID="Label9" runat="server" Text="Total Price: "></asp:Label>
        <br />
        <asp:Button ID="ConfirmBtn" runat="server" Text="Confirm Order" />
        <asp:Button ID="ReturnBtn" runat="server" Text="Return" />
    
    </div>
</asp:Content>

