<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentScheduling.aspx.cs" Inherits="DrewOlsonAssignment3.Student.StudentScheduling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 107px;
        }
        .auto-style4 {
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AppointmentID" DataSourceID="AppointmentSourceStudent" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="AppointmentTime" HeaderText="AppointmentTime" SortExpression="AppointmentTime" />
                <asp:BoundField DataField="AppointmentDate" HeaderText="AppointmentDate" SortExpression="AppointmentDate" />
                <asp:BoundField DataField="AppointmentReason" HeaderText="AppointmentReason" SortExpression="AppointmentReason" />
                <asp:BoundField DataField="AdvisorUserName" HeaderText="AdvisorUserName" SortExpression="AdvisorUserName" />
                <asp:BoundField DataField="StudentUserName" HeaderText="StudentUserName" SortExpression="StudentUserName" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="AppointmentSourceStudent" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [AppointmentTable] WHERE ([StudentUserName] = @StudentUserName)">
            <SelectParameters>
                <asp:SessionParameter Name="StudentUserName" SessionField="UserName" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
</p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Remove Selected Appointment" />
</p>
    <p>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged">
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
        <TodayDayStyle BackColor="#CCCCCC" />
    </asp:Calendar>
</p>
    <p>
        &nbsp;</p>
    <p>
        Reason:</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Width="1177px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Time: (Appointments last 30 minutes)</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4" Width="46px">00</asp:TextBox>
&nbsp;:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="59px">00</asp:TextBox>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>AM</asp:ListItem>
            <asp:ListItem>PM</asp:ListItem>
        </asp:DropDownList>
</p>
<p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" Width="100px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Confirmation.aspx">Confirmation</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
</asp:Content>
