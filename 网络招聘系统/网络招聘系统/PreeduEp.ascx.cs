using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class PreeduEp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Estarttime
        {
            get
            {
                return Literal1.Text;
            }
            set
            {
                Literal1.Text = value;
            }
        }
        public string Eendtime
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
        public string Eschool
        {
            get
            {
                return Literal2.Text;
            }
            set
            {
                Literal2.Text = value;
            }
        }
        public string Emajor
        {
            get
            {
                return Literal4.Text;
            }
            set
            {
                Literal4.Text = value;
            }
        }
        public string Edegree
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
        public string Emiaoshu
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
    }
}