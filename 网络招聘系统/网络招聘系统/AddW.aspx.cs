using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class AddW : System.Web.UI.Page
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
                /*判断是新建还是修改*/

         
                if ("new".Equals(Request["isnew"].ToString()))
                {
                    counts.Text = "1";
                }

            }
            FillWorkEp(Int32.Parse(rid.Text));
            int _counts = Int32.Parse(counts.Text.Trim().ToString());
            AddworkEs(_counts);

       
        }

        private void AddworkEs(int _counts)
        {

            for (int i = 0; i < _counts; i++)
            {
                Control cwep = LoadControl("WorkEp.ascx");
                WorkEp wep = (WorkEp)cwep;
                PlaceHolder1.Controls.Add(wep);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AddworkEs(1);
            counts.Text = (Int32.Parse(counts.Text.Trim().ToString()) + 1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _rid = rid.Text;
            string _isnew = "new";
            foreach (WorkEp wep in PlaceHolder1.Controls)
            {


                if (wep.Wid == "n")//新添加的工作经历
                {
                    var newWe = new BS_rwork
                    {
                        rID = Int32.Parse(_rid),
                        w_s_time = wep.Wstarttime,
                        w_e_time=wep.Wendtime,
                        w_company = wep.Wcompany,
                        w_bumen = wep.Wbumen,
                        w_zhiwei=wep.Wzhiwei,
                        w_miaoshu = wep.Wmiaoshu,
                    };
                    bsdata.BS_rwork.InsertOnSubmit(newWe);
                }
                else//修改后保存的工作经历
                {
                    BS_rwork rw = bsdata.BS_rwork.First(w => w.ID == Int32.Parse(wep.Wid));
                    rw.w_s_time = wep.Wstarttime;
                    rw.w_e_time = wep.Wendtime;
                    rw.w_company = wep.Wcompany;
                    rw.w_bumen = wep.Wbumen;
                    rw.w_zhiwei = wep.Wzhiwei;
                    rw.w_miaoshu = wep.Wmiaoshu;
                    _isnew = "old";
                }

            }
            bsdata.SubmitChanges();

            Response.Redirect("AddE.aspx?rid=" + _rid+"&isnew="+_isnew);
        }
        private void FillWorkEp(int _rid)
        {

            var result = from rw in bsdata.BS_rwork
                         where rw.rID == _rid
                         select rw;

            foreach (BS_rwork rw in result)
            {
                Control wep = LoadControl("WorkEp.ascx");
                WorkEp w = (WorkEp)wep;
                w.Wstarttime = rw.w_s_time;
                w.Wendtime = rw.w_e_time;
                w.Wcompany = rw.w_company;
                w.Wbumen = rw.w_bumen;
                w.Wzhiwei = rw.w_zhiwei;
                w.Wmiaoshu = rw.w_miaoshu;
                w.Wid = rw.ID.ToString();
                PlaceHolder1.Controls.Add(w);

                //Response.Write(w.Wid);
            }


        }

       
    }
}