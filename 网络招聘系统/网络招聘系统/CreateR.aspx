<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateR.aspx.cs"
    Inherits="网络招聘系统.CreateR" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="trid" runat="server" Text="n" Visible="false"></asp:TextBox>
    <div>
        <span>简历名称</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        <span>个人信息</span>
    </div>
    <table>
        <tr>
            <td>
                姓名
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                性别
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                年龄
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                学历
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                电话
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                身高
            </td>
            <td>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
            <td>
                籍贯
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                党派
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td>
                婚否
            </td>
            <td>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                地址
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox9" runat="server" Width="356px"></asp:TextBox>
           
            </td>
        </tr>
    </table>
    <div>
        <asp:Button ID="Button1" runat="server" Text="保存并添加工作经历" OnClick="Button1_Click" />
    </div>
</asp:Content>
