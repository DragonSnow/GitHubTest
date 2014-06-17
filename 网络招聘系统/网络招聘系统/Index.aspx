<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs"
    Inherits="网络招聘系统.Index" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    
        <tr>
            <td>
                <div id="left">
                    <div>
                        <span id="bt_login">登录</span> <span id="bt_sign">注册</span>
                    </div>
                    <div id="login">
                        <asp:Label ID="loginerror" runat="server" Text=""></asp:Label>
                        <div>
                            <span>电子邮箱</span><asp:TextBox ID="tpemail" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <span>密码</span><asp:TextBox ID="tppsw" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="个人用户" Checked="true" GroupName="type" />
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="企业用户" GroupName="type" />
                        </div>
                        <div>
                            <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
                        </div>
                    </div>
                    <div id="sign">
                        <asp:Label ID="signerror" runat="server" Text=""></asp:Label>
                        <div>
                            <span>电子邮箱</span><asp:TextBox ID="ztemail" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <span>密码</span><asp:TextBox ID="ztpsw" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Button ID="Button3" runat="server" Text="个人用户注册" OnClick="Button3_Click" />
                            <asp:Button ID="Button2" runat="server" Text="企业用户注册" OnClick="Button2_Click" />
                        </div>
                    </div>
                </div>
            </td>
            <td >
                <div id="right">
                    <div id="search">
                        <span>地区</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <span>行业</span><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <span>薪水</span><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <span>级别</span><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button4" runat="server" Text="查询" onclick="Button4_Click" />
                    </div>
                    </div>
                </td>
                </tr>
                <tr>
                <td>
                </td>
                <td>
                <div >
                    <div id="l_job">
                        <div>
                            <span>最新职位</span>
                        </div>
                        <div>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="j_name" HeaderText="职位名称" />
                                    <asp:BoundField DataField="c_name" HeaderText="公司名称" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <div id="l_resume">
                        <div>
                            <span>最新简历</span>
                        </div>
                        <div>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="r_name" HeaderText="简历名称" />
                                    <asp:BoundField DataField="p_email" HeaderText="用户" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    
                </div>
            </td>
        </tr>
    
  
    </table>
</asp:Content>
