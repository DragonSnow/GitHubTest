<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddW.aspx.cs"
    Inherits="网络招聘系统.AddW" %>

<%@ Register Src="WorkEp.ascx" TagName="WorkEp" TagPrefix="uc1" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <span>工作经历</span>
    </div>
    <asp:TextBox ID="counts" runat="server" Visible="false" Text="0"></asp:TextBox>
    <asp:TextBox ID="rid" runat="server"  Visible="false"></asp:TextBox>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
    </asp:PlaceHolder>
    <div>
        <asp:Button ID="Button2" runat="server" Text="再添加一个工作经历" OnClick="Button2_Click" />
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="保存并添加教育经历" 
            onclick="Button1_Click" />
        <br />
       
    </div>
</asp:Content>
