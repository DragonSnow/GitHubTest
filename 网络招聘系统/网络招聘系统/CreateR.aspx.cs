using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class CreateR : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PE"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            if (!IsPostBack&&Request["rid"] != null)
            {
                trid.Text = Request["rid"].ToString();
                FillTheR(Int32.Parse(Request["rid"].ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _rname = TextBox1.Text.Trim().ToString();
            string _name = TextBox3.Text.Trim().ToString();
            string _sex = TextBox4.Text.Trim().ToString();
            string _age = TextBox5.Text.Trim().ToString();
            string _degree = TextBox6.Text.Trim().ToString();
            string _phone = TextBox7.Text.Trim().ToString();
            string _email = TextBox8.Text.Trim().ToString();
            string _address = TextBox9.Text.Trim().ToString();
            string _height = TextBox13.Text.Trim().ToString();
            string _jiguan = TextBox10.Text.Trim().ToString();
            string _hunfou = TextBox12.Text.Trim().ToString();
            string _dangpai = TextBox11.Text.Trim().ToString();
            int PID = Int32.Parse(Session["PID"].ToString());
            string _time = DateTime.Now.ToString();
            string rid = trid.Text;
            string _isnew = "new";
            if (trid.Text == "n")
            {
                var newRs = new BS_resume
                {
                    pID = PID,
                    r_name = _rname,
                    p_name = _name,
                    p_sex = _sex,
                    p_age = _age,
                    p_degree = _degree,
                    p_phone = _phone,
                    p_email = _email,
                    p_height=_height,
                    p_jiguan=_jiguan,
                    p_hunfou=_hunfou,
                    p_dangpai=_dangpai,
                    p_address = _address,
                    r_time=_time,
                };
                bsdata.BS_resume.InsertOnSubmit(newRs);
                
                bsdata.SubmitChanges();
                rid = newRs.ID.ToString();
            }
            else
            {
                BS_resume r = bsdata.BS_resume.First(r1 => r1.ID == Int32.Parse(trid.Text));
                r.r_name = _rname;
                r.p_name = _name;
                r.p_sex = _sex;
                r.p_age = _age;
                r.p_degree = _degree;
                r.p_phone = _phone;
                r.p_email = _email;
                r.p_height=_height;
                r.p_hunfou=_hunfou;
                r.p_jiguan=_jiguan;
                r.p_dangpai = _dangpai;
                r.p_address = _address;
                r.r_time = _time;
                bsdata.SubmitChanges();

                _isnew = "old";
            }
            Response.Redirect("AddW.aspx?rid=" + rid+"&isnew="+_isnew);
        }
        private void FillTheR(int _rid)
        {
            var result = from r in bsdata.BS_resume
                         where r.ID == _rid
                         select r;
            BS_resume _r = result.First();
            TextBox1.Text = _r.r_name;
            TextBox3.Text = _r.p_name;
            TextBox4.Text = _r.p_sex;
            TextBox5.Text = _r.p_age;
            TextBox6.Text = _r.p_degree;
            TextBox7.Text = _r.p_phone;
            TextBox8.Text = _r.p_email;
            TextBox13.Text = _r.p_height;
            TextBox10.Text = _r.p_jiguan;
            TextBox11.Text = _r.p_dangpai;

            TextBox12.Text = _r.p_hunfou;
            TextBox9.Text = _r.p_address;
            Button1.Text = "保存并编辑工作经历";
        }
    }
}