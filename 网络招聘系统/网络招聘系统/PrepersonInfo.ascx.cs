using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class PrepersonInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Pname
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
        public string Psex
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
        public string Pages
        {
            get
            {
                return Literal3.Text;
            }
            set
            {
                Literal3.Text = value;
            }
        }
        public string Pdegree
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
        public string Pphone
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
        public string Pemail
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
        public string Pheight
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
        public string Pjiguan
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
        public string Pdangpai
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
        public string Phunfou
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
        public string Paddress
        {
            get
            {
                return Literal11.Text;
            }
            set
            {
                Literal11.Text = value;
            }
        }
    }
}