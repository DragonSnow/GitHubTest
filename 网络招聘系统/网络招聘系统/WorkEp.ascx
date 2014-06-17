<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WorkEp.ascx.cs" Inherits="网络招聘系统.WorkEp" %>
<asp:TextBox ID="TextBox5" runat="server" Text="n" Visible="false"></asp:TextBox>
<table>
    <tr>
        <td>
            时间
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            到
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            格式为yyyy-mm-dd
        </td>
    </tr>
    <tr>
        <td>
            公司
        </td>
        <td colspan="3">
            <asp:TextBox ID="TextBox3" runat="server" Height="19px" Width="348px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            部门
        </td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>
            职位
        </td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            工作描述
        </td>
        <td colspan="3">
            <asp:TextBox ID="TextBox10" runat="server" TextMode="MultiLine" Height="133px" Width="346px"></asp:TextBox>
        </td>
        <td>
            请详细描述<br />
            您的职责范<br />
            围、工作任<br />
            务以及取得<br />
            的成绩等<br />
            (100汉字以内)
        </td>
    </tr>
</table>
