<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RPreview.aspx.cs" Inherits="网络招聘系统.RPreview" %>

<%@ Register src="PrepersonInfo.ascx" tagname="PrepersonInfo" tagprefix="uc1" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
    </div>
</asp:Content>