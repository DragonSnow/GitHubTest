<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PreworkEp.ascx.cs" Inherits="网络招聘系统.PreworkEp" %>
<div style="line-height: 40px; border-bottom-style: solid; border-bottom-width: 1px;
    background-color: #C0C0C0;">
    <span>工作经历</span>
</div>
<table>
    <tr>
        <td>
            时间
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
            到
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td>
            公司
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td style="width:100px;">
            部门
        </td>
        <td style="width:350px;">
            <asp:Literal ID="Literal8" runat="server"></asp:Literal>
        </td>
        <td style="width:100px;">
            职位
        </td>
        <td>
            <asp:Literal ID="Literal9" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td>
            工作描述
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal10" runat="server"></asp:Literal>
        </td>
    </tr>
</table>
