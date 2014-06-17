<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="JobInfo.aspx.cs" Inherits="网络招聘系统.JobInfo" %>


<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="jid" runat="server" Visible="false"></asp:TextBox>
    <table>
        <tr>
            <td>
                公司名称
            </td>
            <td colspan="3">
                <asp:Literal ID="Literal9" runat="server"></asp:Literal>
            </td>
          
        </tr>
        <tr>
            <td>
                职位名称
            </td>
            <td colspan="3">
                <asp:Literal ID="Literal8" runat="server"></asp:Literal>
            </td>
          
        </tr>
        <tr>
            <td style="width:100px;">
                发布时间
            </td>
            <td  style="width:300px;">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
            <td  style="width:100px;">
                工作城市
            </td>
            <td  style="width:300px;">
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                招聘人数
            </td>
            <td>
                <asp:Literal ID="Literal3" runat="server"></asp:Literal>
            </td>
            <td>
                工作年限
            </td>
            <td>
                <asp:Literal ID="Literal4" runat="server"></asp:Literal>
            </td>
        </tr>
       
        <tr>
            <td>
                学历要求
            </td>
            <td>
                <asp:Literal ID="Literal5" runat="server"></asp:Literal>
            </td>
            <td>
                薪资范围
            </td>
            <td>
                <asp:Literal ID="Literal6" runat="server"></asp:Literal>
            </td>
        </tr>
       
        <tr>
            <td>
                职位描述
            </td>
            <td colspan="3">
                <asp:Literal ID="Literal7" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
    <div>
        <asp:Button ID="Button1" runat="server" Text="申请职位" onclick="Button1_Click" />
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="简历编号" />
                <asp:BoundField DataField="r_name" HeaderText="简历名称" />
                <asp:CommandField HeaderText="选择" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="everr" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>