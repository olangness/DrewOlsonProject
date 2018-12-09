<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="DrewOlsonAssignment3.Email" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 131px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                Send To<br />
                first.last@ndsu.edu:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                Email Subject:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="284px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Email Body:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="133px" Width="288px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Height="81px" OnClick="Button1_Click" Text="Send Email" Width="115px" />
            </td>
        </tr>
    </table>
</p>
</asp:Content>
