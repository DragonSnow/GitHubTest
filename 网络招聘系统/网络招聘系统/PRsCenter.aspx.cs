using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class PRsCenter : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PE"] == null)
            {
                
                Response.Redirect("Index.aspx?error=''");
            }
            luemail.Text = Session["PE"].ToString();
            var result = from r in bsdata.BS_resume
                         where r.pID == Int32.Parse(Session["PID"].ToString())
                         select r;
            GridView1.DataSource = result;
            GridView1.DataBind();
        }

        
    }
}