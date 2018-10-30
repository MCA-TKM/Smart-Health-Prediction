<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="breast_cancer.aspx.cs" Inherits="breast_cancer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 803px;
        }
        .style2
        {
            width: 74px;
        }
        .style3
        {
            width: 84px;
        }
        .style7
        {
            width: 280px;
        }
        .style8
        {
            width: 535px;
        }
        .style9
        {
            width: 464px;
        }
        .style10
        {
            width: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        PLEASE ENTER THE LAB REPORTS&nbsp;</p>

    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style8">
                Age:</td>
            <td class="style10">
                <asp:DropDownList ID="age" runat="server">
                    <asp:ListItem>10-19</asp:ListItem>
                    <asp:ListItem>20-29</asp:ListItem>
                    <asp:ListItem>30-39</asp:ListItem>
                    <asp:ListItem>40-49</asp:ListItem>
                    <asp:ListItem>50-59</asp:ListItem>
                    <asp:ListItem>60-69</asp:ListItem>
                    <asp:ListItem>70-79</asp:ListItem>
                    <asp:ListItem>80-89</asp:ListItem>
                    <asp:ListItem>90-99</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
            </td>
            <td class="style9">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Menopause:</td>
            <td class="style10">
                <asp:DropDownList ID="meno" runat="server">
                    <asp:ListItem>It40</asp:ListItem>
                    <asp:ListItem>ge40</asp:ListItem>
                    <asp:ListItem>premeno</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Tumor size:</td>
            <td class="style10">
                <asp:DropDownList ID="tumorsize" runat="server">
                    <asp:ListItem>0-4</asp:ListItem>
                    <asp:ListItem>5-9</asp:ListItem>
                    <asp:ListItem>10-14</asp:ListItem>
                    <asp:ListItem>15-19</asp:ListItem>
                    <asp:ListItem>20-24</asp:ListItem>
                    <asp:ListItem>25-29</asp:ListItem>
                    <asp:ListItem>30-34</asp:ListItem>
                    <asp:ListItem>35-39</asp:ListItem>
                    <asp:ListItem>40-44</asp:ListItem>
                    <asp:ListItem>45-49</asp:ListItem>
                    <asp:ListItem>50-54</asp:ListItem>
                    <asp:ListItem>55-59</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Inv-nodes:</td>
            <td class="style10">
                <asp:DropDownList ID="inv" runat="server">
                    <asp:ListItem>0-2</asp:ListItem>
                    <asp:ListItem>3-5</asp:ListItem>
                    <asp:ListItem>6-8</asp:ListItem>
                    <asp:ListItem>9-11</asp:ListItem>
                    <asp:ListItem>12-14</asp:ListItem>
                    <asp:ListItem>15-17</asp:ListItem>
                    <asp:ListItem>18-20</asp:ListItem>
                    <asp:ListItem>21-23</asp:ListItem>
                    <asp:ListItem>24-26</asp:ListItem>
                    <asp:ListItem>27-29</asp:ListItem>
                    <asp:ListItem>30-32</asp:ListItem>
                    <asp:ListItem>33-35</asp:ListItem>
                    <asp:ListItem>36-39</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Node-caps:</td>
            <td class="style10">
                <asp:DropDownList ID="nodec" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
            </td>
            <td class="style8">
                Deg-malig:</td>
            <td class="style10">
                <asp:DropDownList ID="deg" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
            </td>
            <td class="style9">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Breast:</td>
            <td class="style10">
                <asp:DropDownList ID="breast" runat="server">
                    <asp:ListItem>Left</asp:ListItem>
                    <asp:ListItem>Right</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Breast-quad:</td>
            <td class="style10">
                <asp:DropDownList ID="breastq" runat="server">
                    <asp:ListItem>left-up</asp:ListItem>
                    <asp:ListItem>left-low</asp:ListItem>
                    <asp:ListItem>right-up</asp:ListItem>
                    <asp:ListItem>right-low</asp:ListItem>
                    <asp:ListItem>central</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                Irradiat:</td>
            <td class="style10">
                <asp:DropDownList ID="irradiat" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                <asp:Button ID="diasub" runat="server" Text="Submit" onclick="Button1_Click" />
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>

