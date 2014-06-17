using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class DeleteR : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string _rid = Request["rid"].ToString();
            BS_resume _r = bsdata.BS_resume.First(r => r.ID == Int32.Parse(_rid));
            bsdata.BS_resume.DeleteOnSubmit(_r);
            bsdata.SubmitChanges();
            Response.Redirect("PRsCenter.aspx");
        }
    }
}