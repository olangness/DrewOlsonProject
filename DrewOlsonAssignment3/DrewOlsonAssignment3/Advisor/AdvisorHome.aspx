<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdvisorHome.aspx.cs" Inherits="DrewOlsonAssignment3.Advisor.AdvisorHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Welcome back, 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Your students are:
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="236px" Width="1019px"></asp:ListBox>
    </p>
</asp:Content>
