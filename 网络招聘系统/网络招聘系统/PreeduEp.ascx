<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PreeduEp.ascx.cs" Inherits="网络招聘系统.PreeduEp" %>
<div style="line-height: 40px; border-bottom-style: solid; border-bottom-width: 1px;
    background-color: #C0C0C0;">
    <span>教育经历</span>
</div>
<table>
    <tr>
        <td>
            时间
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            到
            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td>
            学校
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td style="width:100px;">
            专业
        </td>
        <td style="width:350px;">
            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
        </td>
        <td style="width:100px;">
            学历
        </td>
        <td>
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td>
            专业描述
        </td>
        <td colspan="3">
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
        </td>
    </tr>
</table>
