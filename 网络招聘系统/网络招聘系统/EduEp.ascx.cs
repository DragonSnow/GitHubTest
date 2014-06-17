using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class EduEp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Eid
        {
            get
            {
                return TextBox6.Text;
            }
            set
            {
                TextBox6.Text = value;
            }
        }
        public string Estarttime
        {
            get
            {
                return TextBox7.Text;
            }
            set
            {
                TextBox7.Text = value;
            }
        }
        public string Eendtime
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
        public string Eschool
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
        public string Emajor
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
        public string Edegree
        {
            get
            {
                return TextBox11.Text;
            }
            set
            {
                TextBox11.Text = value;
            }
        }
        public string Emiaoshu
        {
            get
            {
                return TextBox12.Text;
            }
            set
            {
                TextBox12.Text = value;
            }
        }
    }
}