<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrepersonInfo.ascx.cs"
    Inherits="网络招聘系统.PrepersonInfo" %>
<div style="line-height: 40px; border-bottom-style: solid; border-bottom-width: 1px; background-color: #C0C0C0;">
<span >个人信息</span>
</div>
<table>
        <tr>
            <td>
                姓名
            </td>
            <td style="width:350px;">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
            <td>
                性别
            </td>
            <td>
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                年龄
            </td>
            <td>
                <asp:Literal ID="Literal3" runat="server"></asp:Literal>
            </td>
            <td>
                学历
            </td>
            <td>
                <asp:Literal ID="Literal4" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                电话
            </td>
            <td>
                <asp:Literal ID="Literal5" runat="server"></asp:Literal>
            </td>
            <td>
                Email
            </td>
            <td>
                <asp:Literal ID="Literal6" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                身高
            </td>
            <td>
                <asp:Literal ID="Literal7" runat="server"></asp:Literal>
            </td>
            <td>
                籍贯
            </td>
            <td>
                <asp:Literal ID="Literal8" runat="server"></asp:Literal>
            </td>
        </tr>
         <tr>
            <td>
                党派
            </td>
            <td>
                <asp:Literal ID="Literal9" runat="server"></asp:Literal>
            </td>
            <td>
                婚否
            </td>
            <td>
                <asp:Literal ID="Literal10" runat="server"></asp:Literal>
            </td>
        </tr>
         <tr>
            <td>
                地址
            </td>
            <td colspan="3">
                <asp:Literal ID="Literal11" runat="server"></asp:Literal>
           
            </td>
        </tr>
    </table>