<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchJob.aspx.cs"
    Inherits="网络招聘系统.SearchJob" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="search">
        <span>地区</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <span>行业</span><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <span>薪水</span><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <span>级别</span><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" Text="查询" OnClick="Button4_Click" />
    </div>
    <div style="display: none;">
        <span>行业类别</span><asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>IT</asp:ListItem>
            <asp:ListItem>互联网</asp:ListItem>
            <asp:ListItem>金融</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div style="display: none;">
        <span>职位类别</span><asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>计算机软件</asp:ListItem>
            <asp:ListItem>移动应用</asp:ListItem>
            <asp:ListItem>嵌入式应用</asp:ListItem>
        </asp:DropDownList>
    </div>
   
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="职位编号" />
            <asp:BoundField DataField="j_name" HeaderText="职位名称" />
            <asp:BoundField DataField="j_city" HeaderText="工作城市" />
            <asp:BoundField DataField="j_xinshui" HeaderText="薪水" />
            <asp:BoundField DataField="c_name" HeaderText="公司名称" />
            <asp:BoundField DataField="c_hangye" HeaderText="公司行业" />
            <asp:CommandField SelectText="详细信息" ShowSelectButton="True" HeaderText="操作" />
        </Columns>
    </asp:GridView>
</asp:Content>
