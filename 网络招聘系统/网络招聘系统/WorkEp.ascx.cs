using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class WorkEp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Wid
        {
            get
            {
                return TextBox5.Text;
            }
            set
            {
                TextBox5.Text = value;
            }
        }

        public string Wstarttime
        {
            get
            {
                return TextBox1.Text;
            }
            set
            {
                TextBox1.Text = value;
            }
        }
        public string Wendtime
        {
            get
            {
                return TextBox2.Text;
            }
            set
            {
                TextBox2.Text = value;
            }
        }
        public string Wcompany
        {
            get
            {
                return TextBox3.Text;
            }
            set
            {
                TextBox3.Text = value;
            }
        }
        public string Wbumen
        {
            get
            {
                return TextBox8.Text;
            }
            set
            {
                TextBox8.Text = value;
            }
        }
        public string Wzhiwei
        {
            get
            {
                return TextBox9.Text;
            }
            set
            {
                TextBox9.Text = value;
            }
        }
        public string Wmiaoshu
        {
            get
            {
                return TextBox10.Text;
            }
            set
            {
                TextBox10.Text = value;
            }

        }
       
    }
}