<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style ="font-size: x-large" align =" center"> Employee Info</div>
        <table class="nav-justified">
            <tr>
                <td style="width: 278px">&nbsp;</td>
                <td style="width: 141px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 278px">&nbsp;</td>
                <td style="width: 141px">Employee Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 278px">&nbsp;</td>
                <td style="width: 141px">Employee Age</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 278px">&nbsp;</td>
                <td style="width: 141px">Employee Salary</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="1377px">
        </asp:GridView>
        <br/>



    </div>

</asp:Content>
