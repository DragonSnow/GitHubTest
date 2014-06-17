using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class SearchJob : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["city"] != null)
            {
                string _city = Request["city"].ToString();
                string _hangye = Request["hangye"].ToString();
                string _xinshui = Request["xinshui"].ToString();
                string _jibie = Request["jibie"].ToString();
                ShowJobs(_city, _hangye, _xinshui, _jibie);
            }
        }

       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _jid = this.GridView1.SelectedRow.Cells[0].Text;

            Response.Redirect("JobInfo.aspx?jid="+_jid);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string city = TextBox1.Text.Trim().ToString();
            string hangye = TextBox2.Text.Trim().ToString();
            string xinshui = TextBox3.Text.Trim().ToString();
            string jibie = TextBox4.Text.Trim().ToString();
            ShowJobs(city, hangye, xinshui, jibie);
        }
        protected void ShowJobs(string _city,string _hangye ,string _xinshui ,string _jibie)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            var result = from job in bsdata.BS_job
                         join company in bsdata.BS_c_info on job.cID equals company.cID
                         where job.j_city.Contains(_city) 
                         where company.c_hangye.Contains(_hangye)
                         select new
                         {
                             job.ID,
                             job.j_name,
                             job.j_city,
                             job.j_xinshui,
                             company.c_name,
                             company.c_hangye,
                         };
            if (result.Count() > 0)
            {
                GridView1.DataSource = result;
                GridView1.DataBind();
            }

        }
    }
}