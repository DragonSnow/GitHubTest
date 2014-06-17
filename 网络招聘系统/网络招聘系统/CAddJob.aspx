<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CAddJob.aspx.cs"
    Inherits="网络招聘系统.CAddJob" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="jid" runat="server" Visible="true" Text="0"></asp:TextBox>
    <table style="width: 871px">
        <tr>
            <td style="width:100px;">
                职位名称
            </td>
            <td style="width:300px;">
                <asp:TextBox ID="TextBox1" runat="server" Width="280px"></asp:TextBox>
            </td>
            <td>
                工作城市
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                招聘人数
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                工作年限
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                &#39;若干&#39;或数字
            </td>
            <td>
            </td>
            <td>
                例如3年以上
            </td>
        </tr>
        <tr>
            <td>
                学历要求
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                薪资范围
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                例如本科
            </td>
            <td>
            </td>
            <td>
                例如面议、3000/月
            </td>
        </tr>
        <tr>
            <td>
                职位描述
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox7" TextMode="MultiLine" runat="server" Height="138px" 
                    Width="780px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="发布职位" OnClick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
</asp:Content>

