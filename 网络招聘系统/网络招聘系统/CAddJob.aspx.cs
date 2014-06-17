using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class CAddJob : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CE"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            if (!IsPostBack&&Request["jid"] != null)
            {
                FillJobinfo(Int32.Parse(Request["jid"].ToString()));
                jid.Text = Request["jid"].ToString();
            }
            //Session["UID"] = "1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _jobname = TextBox1.Text.Trim().ToString();
            string _jobcity = TextBox2.Text.Trim().ToString();
            string _jobrenshut = TextBox3.Text.Trim().ToString();
            string _jobnianxian = TextBox4.Text.Trim().ToString();
            string _jobdegree = TextBox5.Text.Trim().ToString();
            string _jobxinzi = TextBox6.Text.Trim().ToString();
            string _jobmiaohsu = TextBox7.Text.Trim().ToString();
            string _jobtime = DateTime.Now.ToShortDateString();
            int _cid = Int32.Parse(Session["CID"].ToString());
            var result = from j in bsdata.BS_job
                         where j.ID == Int32.Parse(jid.Text)
                         select j;
            if (result.Count() > 0)
            {
                BS_job job = bsdata.BS_job.First(j => j.ID == Int32.Parse(jid.Text));
                job.cID = _cid;
                job.j_name = _jobname;
                job.j_city = _jobcity;
                job.j_renshu = _jobrenshut;
                job.j_nianxian = _jobnianxian;
                job.j_xinshui = _jobxinzi;
                job.j_degree = _jobdegree;
                job.j_miaoshu = _jobmiaohsu;
                job.j_time = _jobtime;
            }
            else
            {

                var newJob = new BS_job
                {
                    cID = _cid,
                    j_name = _jobname,
                    j_city = _jobcity,
                    j_renshu = _jobrenshut,
                    j_nianxian = _jobnianxian,
                    j_xinshui = _jobxinzi,
                    j_degree = _jobdegree,
                    j_miaoshu = _jobmiaohsu,
                    j_time = _jobtime,
                };
                bsdata.BS_job.InsertOnSubmit(newJob);
            }
            bsdata.SubmitChanges();
            Response.Redirect("CJobCenter.aspx");

        }
        protected void FillJobinfo(int _jid)
        {
            var resultj = from j in bsdata.BS_job
                          where j.ID == _jid
                          select j;
            BS_job job = resultj.First();
            TextBox1.Text = job.j_name;
            TextBox2.Text = job.j_city;
            TextBox3.Text = job.j_renshu;
            TextBox4.Text = job.j_nianxian;
            TextBox5.Text = job.j_degree;
            TextBox6.Text = job.j_xinshui;
            TextBox7.Text = job.j_miaoshu;
            Button1.Text = "保存修改";
        }
    }
}