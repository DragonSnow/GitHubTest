using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class JobInfo : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["jid"] == null)
            {
                Response.Redirect("SearchJob.aspx");
            }
            jid.Text=Request["jid"].ToString();
            int _jid = Int32.Parse(jid.Text);
            ShowJob(_jid);
        }
        private void ShowJob(int _jid)
        {
            var resultj = from j in bsdata.BS_job
                          where j.ID == _jid
                          select j;

            int cid = (int)resultj.First().cID;

            Literal8.Text = resultj.First().j_name;
            Literal1.Text = resultj.First().j_time;
            Literal2.Text = resultj.First().j_city;
            Literal3.Text = resultj.First().j_renshu;
            Literal4.Text = resultj.First().j_nianxian;
            Literal5.Text = resultj.First().j_degree;
            Literal6.Text = resultj.First().j_xinshui;
            Literal7.Text = resultj.First().j_miaoshu;
            var resultc = from c in bsdata.BS_company
                          where c.ID == cid
                          select c;
            Literal9.Text = resultc.First().c_name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["PE"] == null)
            {
                Response.Redirect("Index.aspx?error=''");
            }
            var resultr = from r in bsdata.BS_resume
                          where r.pID == Int32.Parse(Session["PID"].ToString())
                          select new
                          {
                              r.ID,
                              r.r_name,
                          };
            GridView1.DataSource = resultr;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _rid=Int32.Parse(this.GridView1.SelectedRow.Cells[0].Text);
            int _jid=Int32.Parse(jid.Text);
            var result = from jr in bsdata.BS_job_resume
                         where jr.jID == _jid && jr.rID == _rid
                         select jr;
            if (result.Count() > 0)
            {
                everr.Text = "已经投过这份简历了，换份简历或换个职位吧！";
            }
            else
            {
                var newJR = new BS_job_resume
                {
                    rID = _rid,
                    jID = _jid,
                };
                bsdata.BS_job_resume.InsertOnSubmit(newJR);
                bsdata.SubmitChanges();
                Response.Redirect("SearchJob.aspx");
            }
        }

                        
    }
}