using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                Control c = LoadControl("WorkEp.ascx");
                WorkEp w = ((WorkEp)c);
                w.Wid = "m";
                PlaceHolder1.Controls.Add(w);
           
          /*
                Control c1 = LoadControl("WorkEp.ascx");
                WorkEp w1 = ((WorkEp)c1);
                PlaceHolder1.Controls.Add(w1);
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (WorkEp w1 in PlaceHolder1.Controls)
            {
                Response.Write(w1.Wid);
               
            }
        }
    }
}