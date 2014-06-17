using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class CJobCenter : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["CE"] == null)
            {
                Response.Redirect("Index.aspx?error=''");
            }
            int _cid = Int32.Parse(Session["CID"].ToString());
            var resultj = from j in bsdata.BS_job
                          where j.cID == _cid
                          select j;

            GridView1.DataSource = resultj;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, EventArgs e)
        {
            GridViewCommandEventArgs _e = (GridViewCommandEventArgs)e;
            if (_e.CommandName == "bt1_click")
            {
                string _jid = this.GridView1.Rows[int.Parse(_e.CommandArgument.ToString())].Cells[0].Text;
                Response.Redirect("CAddJob.aspx?jid=" + _jid);
            }
            if (_e.CommandName == "bt2_click")
            {
                string _jid = this.GridView1.Rows[int.Parse(_e.CommandArgument.ToString())].Cells[0].Text;
                var result = from jr in bsdata.BS_job_resume
                             join r in bsdata.BS_resume on jr.rID equals r.ID
                             where jr.jID == Int32.Parse(_jid)
                             select new { 
                             rid=r.ID,
                             jrid=jr.ID,
                             r.r_name,
                             r.p_name,
                             r.p_degree,
                             r.p_sex,
                             };
                GridView2.DataSource = result;
                GridView2.DataBind();
            }
        }

      
    }
}