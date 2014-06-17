using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class AddE : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PE"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            if (!IsPostBack)
            {
                if (Request["rid"] != null)
                {
                    rid.Text = Request["rid"].ToString();

                }
                else
                {
                    Response.Redirect("CreateR.aspx");
                }
                /*判断是新建还是修改* */

                if ("new".Equals(Request["isnew"].ToString()))
                {
                    counts.Text = "1";
                }

            }
            FillEdu(Int32.Parse(rid.Text));
            int _counts = Int32.Parse(counts.Text.Trim().ToString());
            AddEdus(_counts);
        }
        private void AddEdus(int _counts)
        {

            for (int i = 0; i < _counts; i++)
            {
                Control cedu = LoadControl("EduEp.ascx");
                EduEp eep = (EduEp)cedu;
                PlaceHolder1.Controls.Add(eep);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            AddEdus(1);
            counts.Text = (Int32.Parse(counts.Text.Trim().ToString()) + 1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _rid = rid.Text;
            foreach (EduEp eep in PlaceHolder1.Controls)
            {
                if (eep.Eid == "n")
                {
                    var newEdu = new BS_redu
                    {
                        rID = Int32.Parse(_rid),
                        e_s_time = eep.Estarttime,
                        e_e_time = eep.Eendtime,
                        e_school = eep.Eschool,
                        e_degree = eep.Edegree,
                        e_major = eep.Emajor,
                        e_miaoshu = eep.Emiaoshu,
                    };
                    bsdata.BS_redu.InsertOnSubmit(newEdu);
                }
                else
                {
                    BS_redu re = bsdata.BS_redu.First(ep=>ep.ID==Int32.Parse(eep.Eid));
                    re.e_s_time = eep.Estarttime;
                    re.e_e_time = eep.Eendtime;
                    re.e_school = eep.Eschool;
                    re.e_major = eep.Emajor;
                    re.e_degree = eep.Edegree;
                    re.e_miaoshu = eep.Emiaoshu;
                }

            }
            bsdata.SubmitChanges();
            Response.Redirect("PRsCenter.aspx");
        }
        private void FillEdu(int _rid)
        {
            var result = from re in bsdata.BS_redu
                         where re.rID == _rid
                         select re;

            foreach (BS_redu re in result)
            {
                Control eep = LoadControl("EduEp.ascx");
                EduEp e = (EduEp)eep;
                e.Estarttime = re.e_s_time;
                e.Eendtime = re.e_e_time;
                e.Eschool = re.e_school;
                e.Emajor = re.e_major;
                e.Edegree = re.e_degree;
                e.Emiaoshu = re.e_miaoshu;
                e.Eid = re.ID.ToString();
                PlaceHolder1.Controls.Add(e);
            }
        }
    }
}