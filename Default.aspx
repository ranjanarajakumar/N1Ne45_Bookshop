<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="css/HomePage_StyleSheet.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
  <div id="container">  
        <div id="header">
            <h1>N1Ne45 BookShop</h1>
        </div>
    <div class="center">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button CssClass="button" ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"/>
    </div>
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" Interval="2000" runat="server"></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <table style="width: 100%;">
                    <tr>
                        <td><asp:AdRotator ID="AdRotator1"  runat="server" AdvertisementFile="~/App_Data/Advertisements.xml" />  </td>
                        <td><asp:AdRotator ID="AdRotator2" runat="server"  AdvertisementFile="~/App_Data/Advertisements2.xml"/></td>
                        <td><asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/App_Data/Advertisements3.xml"/></td>
                    </tr>                   
                </table>                 
            </ContentTemplate>
        </asp:UpdatePanel><br/>
    </div>
        <div>
            <h2 id="h2">Books Hot New Releases</h2>
            <table style="width: 100%;">
                <tr>
                    <td><asp:Image ID="Image1" runat="server" /></td>
                    <td><asp:Image ID="Image2" runat="server" /></td>
                    <td><asp:Image ID="Image3" runat="server" /></td>
                    <td><asp:Image ID="Image4" runat="server" /></td>
                    <td><asp:Image ID="Image5" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbBook1Name" runat="server" Text="Label"></asp:Label><br/>
                        <asp:Label ID="lbBook1Author" runat="server" Text="Label"></asp:Label><br/>
                        <asp:Label ID="lbBook1Price" runat="server" Text="Label"></asp:Label><br/>
                    </td>
                    <td>
                        <asp:Label ID="lbBook2Name" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook2Author" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook2Price" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbBook3Name" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook3Author" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook3Price" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbBook4Name" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook4Author" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook4Price" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbBook5Name" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook5Author" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbBook5Price" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
</div>
</asp:Content>

