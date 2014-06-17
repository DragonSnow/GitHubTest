using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class DeleteRJ : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string _jrid = Request["jrid"].ToString();
            BS_job_resume _r = bsdata.BS_job_resume.First(jr => jr.ID == Int32.Parse(_jrid));
            bsdata.BS_job_resume.DeleteOnSubmit(_r);
            bsdata.SubmitChanges();
            Response.Redirect("CJobCenter.aspx");
        }
    }
}