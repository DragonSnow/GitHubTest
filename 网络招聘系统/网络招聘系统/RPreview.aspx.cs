using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class RPreview : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string _rid=Request["rid"].ToString();
            //Response.Write(Request["rid"]);
            var result = from rinfo in bsdata.BS_resume
                         where rinfo.ID == Int32.Parse(_rid)
                         select rinfo;
            Control _c_rinfo = LoadControl("PrepersonInfo.ascx");
            PrepersonInfo _rinfo = (PrepersonInfo)_c_rinfo;
            BS_resume _r=result.First();
            _rinfo.Pname = _r.p_name;
            _rinfo.Psex = _r.p_sex;
            _rinfo.Pages = _r.p_age;
            _rinfo.Pdegree = _r.p_degree;
            _rinfo.Pphone = _r.p_phone;
            _rinfo.Pemail = _r.p_email;
            _rinfo.Pheight = _r.p_height;
            _rinfo.Pjiguan = _r.p_jiguan;
            _rinfo.Phunfou = _r.p_hunfou;
            _rinfo.Pdangpai = _r.p_dangpai;
            _rinfo.Paddress = _r.p_address;
            PlaceHolder1.Controls.Add(_rinfo);
            var result2 = from rwork in bsdata.BS_rwork
                          where rwork.rID == Int32.Parse(_rid)
                          select rwork;
            foreach (BS_rwork _w in result2)
            {
                Control _c_rwork = LoadControl("PreworkEp.ascx");
                PreworkEp _rwork = (PreworkEp)_c_rwork;
                _rwork.Wstarttime = _w.w_s_time;
                _rwork.Wendtime = _w.w_e_time;
                _rwork.Wcompany = _w.w_company;
                _rwork.Wzhiwei = _w.w_zhiwei;
                _rwork.Wbumen = _w.w_bumen;
                _rwork.Wmiaoshu = _w.w_miaoshu;
                PlaceHolder1.Controls.Add(_rwork);
            }
            var result3 = from redu in bsdata.BS_redu
                          where redu.rID == Int32.Parse(_rid)
                          select redu;
            foreach (BS_redu _e in result3)
            {
                Control _c_redu = LoadControl("PreeduEp.ascx");
                PreeduEp _redu = (PreeduEp)_c_redu;
                _redu.Estarttime = _e.e_s_time;
                _redu.Eendtime = _e.e_e_time;
                _redu.Eschool = _e.e_school;
                _redu.Emajor = _e.e_major;
                _redu.Edegree = _e.e_degree;
                _redu.Emiaoshu = _e.e_miaoshu;

                PlaceHolder1.Controls.Add(_redu);
            }
        }
    }
}