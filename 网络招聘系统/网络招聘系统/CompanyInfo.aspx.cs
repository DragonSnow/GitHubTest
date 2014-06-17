using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class CompanyInfo : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CE"] == null)
            {
                Response.Redirect("Index.aspx?error=''");
            }
            FillCInfo(Int32.Parse(Session["CID"].ToString()));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _cname = TextBox1.Text.Trim().ToString();
            string _cxingzhi = TextBox2.Text.Trim().ToString();
            string _changye = TextBox3.Text.Trim().ToString();
            string _cguimo = TextBox4.Text.Trim().ToString();
            string _ctellphone = TextBox5.Text.Trim().ToString();
            string _cemail = TextBox6.Text.Trim().ToString();
            string _cwebsite = TextBox7.Text.Trim().ToString();
            string _caddress = TextBox8.Text.Trim().ToString();
            string _cjianjie = TextBox9.Text.Trim().ToString();
            int _cID = Int32.Parse(Session["CID"].ToString());
            var result = from cinfo in bsdata.BS_c_info
                         where cinfo.cID == _cID
                         select cinfo;
            if (result.Count() > 0)
            {
                BS_c_info Cinfo = bsdata.BS_c_info.First(ci => ci.cID == _cID);
                Cinfo.c_name = _cname;
                Cinfo.c_xingzhi = _cxingzhi;
                Cinfo.c_hangye = _changye;
                Cinfo.c_guimo = _cguimo;
                Cinfo.c_tellphone = _ctellphone;
                Cinfo.c_email = _cemail;
                Cinfo.c_website = _cwebsite;
                Cinfo.c_address = _caddress;
                Cinfo.c_jianjie = _cjianjie;
                BS_company Company = bsdata.BS_company.First(cm => cm.ID == _cID);
                Company.c_name = _cname;
            }
            else
            {


                BS_c_info newCinfo = new BS_c_info
                {
                    cID = _cID,
                    c_name = _cname,
                    c_xingzhi = _cxingzhi,
                    c_hangye = _changye,
                    c_guimo = _cguimo,
                    c_tellphone = _ctellphone,
                    c_email = _cemail,
                    c_website = _cwebsite,
                    c_address = _caddress,
                    c_jianjie = _cjianjie,

                };

                bsdata.BS_c_info.InsertOnSubmit(newCinfo);
                BS_company Company = bsdata.BS_company.First(cm => cm.ID == _cID);
                Company.c_name = _cname;
            } bsdata.SubmitChanges();
        }
        protected void FillCInfo(int _CID)
        {
            var result = from ci in bsdata.BS_c_info
                         where ci.cID == _CID
                         select ci;
            if (result.Count() > 0)
            {
                BS_c_info CInfo = result.First();
                TextBox1.Text = CInfo.c_name;
                TextBox2.Text = CInfo.c_xingzhi;
                TextBox3.Text = CInfo.c_hangye;

                TextBox4.Text = CInfo.c_guimo;
                TextBox5.Text = CInfo.c_tellphone;
                TextBox6.Text = CInfo.c_email;
                TextBox7.Text = CInfo.c_website;

                TextBox8.Text = CInfo.c_address;
                TextBox9.Text = CInfo.c_jianjie;
            }
        }
    }
}