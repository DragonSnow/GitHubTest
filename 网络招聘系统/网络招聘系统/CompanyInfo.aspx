<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanyInfo.aspx.cs"
    Inherits="网络招聘系统.CompanyInfo" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="width:100px;">
                公司名称
            </td>
            <td style="width:300px;">
                <asp:TextBox ID="TextBox1" runat="server" Width="280px"></asp:TextBox>
            </td>
            <td style="width:100px;">
                公司性质
            </td>
            <td  style="width:300px;">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                公司行业
            </td>
            <td>
                <asp:TextBox ID="TextBox3" Width="180px" runat="server"></asp:TextBox>
            </td>
            <td>
                公司规模
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                公司电话
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>
                公司邮箱
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="230px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                公司网站
            </td>
            <td colspan="3" >
                <asp:TextBox ID="TextBox7" runat="server" Width="400px"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>
                公司地址
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox8" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                公司简介
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox9" runat="server" Width="700px" Height="200px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td><td></td>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="保存" onclick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
