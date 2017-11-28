<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageForAdmin.master" AutoEventWireup="true" CodeFile="UpdateDiscount.aspx.cs" Inherits="Admin_UpdateDiscount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/HomePage_StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="container">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" OnFinishButtonClick="Wizard1_FinishButtonClick" ActiveStepIndex="2">
                <StepNavigationTemplate>
                    <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                    <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" />
                </StepNavigationTemplate>
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Update All" /><asp:RadioButton ID="RadioButton2" runat="server" Text="Update by Search" />
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                        <asp:TextBox ID="SearchTextBox" runat="server"></asp:TextBox><asp:Button CssClass="button" ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" /><Br/>
                        <asp:GridView ID="SearchGridView" runat="server"></asp:GridView>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
                        <asp:Label ID="Label1" runat="server" Text="Please Enter theDiscount: "></asp:Label><asp:TextBox ID="DiscountTextBox" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </div>
</asp:Content>

