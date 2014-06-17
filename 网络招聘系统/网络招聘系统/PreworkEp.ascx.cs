using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class PreworkEp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Wstarttime
        {
            get
            {
                return Literal5.Text;
            }
            set
            {
                Literal5.Text = value;
            }
        }
        public string Wendtime
        {
            get
            {
                return Literal6.Text;
            }
            set
            {
                Literal6.Text = value;
            }
        }
        public string Wcompany
        {
            get
            {
                return Literal7.Text;
            }
            set
            {
                Literal7.Text = value;
            }
        }
        public string Wbumen
        {
            get
            {
                return Literal8.Text;
            }
            set
            {
                Literal8.Text = value;
            }
        }
        public string Wzhiwei
        {
            get
            {
                return Literal9.Text;
            }
            set
            {
                Literal9.Text = value;
            }
        }
        public string Wmiaoshu
        {
            get
            {
                return Literal10.Text;
            }
            set
            {
                Literal10.Text = value;
            }
        }
    }
}