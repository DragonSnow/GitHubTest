<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EduEp.ascx.cs" Inherits="网络招聘系统.EduEp" %>
<asp:TextBox ID="TextBox6" runat="server" Text="n" Visible="false"></asp:TextBox>

<table>
    <tr>
        <td>
            时间
        </td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td>
            到
        </td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>
            格式为yyyy-mm-dd
        </td>
    </tr>
    <tr>
        <td>
            学校
        </td>
        <td colspan="3">
            <asp:TextBox ID="TextBox9" runat="server" Height="19px" Width="348px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            专业
        </td>
        <td>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </td>
        <td>
            学历
        </td>
        <td>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            专业描述
        </td>
        <td colspan="3">
            <asp:TextBox ID="TextBox12" runat="server" TextMode="MultiLine" Height="133px" Width="346px"></asp:TextBox>
        </td>
        <td>
        填写您所学专业<br />
            包括什么课程，<br />
            您的毕业设计等<br />
            等
            (100汉字以内)</td>
    </tr>
</table>