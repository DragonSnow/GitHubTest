using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Testmd5();
            int _counts = Int32.Parse(TextBox1.Text.Trim().ToString());
            //AddworkEs(_counts);
        }
        private void AddworkEs(int _counts)
        {
            
            for (int i = 0; i < _counts; i++)
            {TextBox tb = new TextBox();
                PlaceHolder1.Controls.Add(tb);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            AddworkEs(1);
            TextBox1.Text = (Int32.Parse(TextBox1.Text.Trim().ToString()) + 1).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = "23";
            Response.Redirect("WebForm2.aspx?id="+id);
        }
        protected void Testmd5() {
            string psw = FormsAuthentication.HashPasswordForStoringInConfigFile("123", "MD5");
            Response.Write(psw);
        }
    }
}