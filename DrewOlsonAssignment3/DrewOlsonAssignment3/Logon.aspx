﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="DrewOlsonAssignment3.Logon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td>
            <br />
            Log in using your username and password<br />
            <br />
            <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/RedirectPage.aspx" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </td>
    </tr>
</table>
</asp:Content>
