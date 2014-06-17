<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddE.aspx.cs"
    Inherits="网络招聘系统.AddE" %>

<%@ Register Src="EduEp.ascx" TagName="EduEp" TagPrefix="uc1" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <span>教育经历</span>
    </div>
    <asp:TextBox ID="counts" Text="0" Visible="false" runat="server"></asp:TextBox>
    <asp:TextBox ID="rid"  Visible="false"  runat="server"></asp:TextBox>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
    </asp:PlaceHolder>
    <div>
        <asp:Button ID="Button2" runat="server" Text="再添加一个教育经历" OnClick="Button2_Click" /></div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" Style="height: 21px" /></div>
</asp:Content>
