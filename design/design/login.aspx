<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 3px;
        }
        .style2
        {
            width: 269px;
        }
        .style3
        {
            width: 27px;
        }
        .style4
        {
            width: 52px;
        }
        .style5
        {
            width: 100%;
        }
        .style6
        {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p><center>LOGIN</center></p>
    <table class="style1">
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="_imgAdmin" runat="server" Height="150px" 
                onclick="_imgAdmin_Click" Width="200px" 
                ImageUrl="~/images/women-admin.jpg" CausesValidation="False" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="150px" 
                onclick="img_patient_click" Width="200px" 
                ImageUrl="~/images/patient.png" CausesValidation="False" />
        </td>
        <td class="style4">
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButton3" runat="server" Height="150px" 
                onclick="ImageButton3_Click" Width="200px" 
                ImageUrl="~/images/hospital.jpg" CausesValidation="False" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
                            <asp:Label ID="Label1" runat="server" Text="..."></asp:Label>
                        </td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td colspan="5" rowspan="2">
            <asp:Panel ID="Panel1" runat="server" Height="195px" style="text-align: center" 
                Width="618px">
                <table class="style5">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            Username</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox1" ErrorMessage="**" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            Password</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TextBox2" ErrorMessage="**" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            </td>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style6">
                            <asp:Button ID="_btnLogin" runat="server" onclick="_btnLogin_Click" 
                                Text="Login" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                                CausesValidation="False">New User</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

