<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PRsCenter.aspx.cs"
    Inherits="网络招聘系统.PRsCenter" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>
            欢迎个人用户：<asp:Label ID="luemail" runat="server" Text="Label"></asp:Label></h3>
        <span>我的简历</span><span><a href="CreateR.aspx">写简历</a></span>
    </div>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="简历编号" />
                <asp:BoundField DataField="r_name" HeaderText="简历名称" />
                <asp:TemplateField HeaderText="操作">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("ID","RPreview.aspx?rid={0}") %>' runat="server">预览</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink3" NavigateUrl='<%# Eval("ID","CreateR.aspx?rid={0}") %>' runat="server">编辑</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# Eval("ID","DeleteR.aspx?rid={0}") %>' runat="server">删除</asp:HyperLink>
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       
    
    </div>
</asp:Content>
