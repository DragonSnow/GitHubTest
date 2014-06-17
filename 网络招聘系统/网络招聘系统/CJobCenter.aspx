<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CJobCenter.aspx.cs" Inherits="网络招聘系统.CJobCenter" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
         OnRowCommand="GridView1_RowCommand" 
        >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="职位编号" />
                <asp:BoundField DataField="j_name" HeaderText="职位名称" />
                <asp:ButtonField HeaderText="操作" CommandName="bt1_click" Text="编辑>>" />
                <asp:ButtonField HeaderText="操作" CommandName="bt2_click" Text="收到的简历>>" 
                     />
            </Columns>
        </asp:GridView>
    
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
         <Columns>
                <asp:BoundField DataField="r_name" HeaderText="简历名称" />
                <asp:BoundField DataField="p_name" HeaderText="姓名" />
                <asp:BoundField DataField="p_degree" HeaderText="学历" />
                <asp:BoundField DataField="p_sex" HeaderText="性别" />

               
                <asp:TemplateField HeaderText="操作">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("rid","RPreview.aspx?rid={0}") %>' runat="server">查看简历</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# Eval("jrid","DeleteRJ.aspx?jrid={0}") %>' runat="server">删除</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>

               
            </Columns>
        </asp:GridView>
    
        <br />
    
    </div>
    <div>
    <span style="display:inline-block;width:300px;"><a href="CAddJob.aspx">发布职位</a></span><span><a href="CompanyInfo.aspx">公司信息</a></span>
    </div>
</asp:Content>