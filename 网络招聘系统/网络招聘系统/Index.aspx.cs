using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网络招聘系统
{
    public partial class Index : System.Web.UI.Page
    {
        BSDataClasseDataContext bsdata = new BSDataClasseDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["error"]!=null)
            {
                Response.Write("<script>alert('请登录！');</script>");
            }
            var resultr =( from r in bsdata.BS_resume
                          join p in bsdata.BS_person on r.pID equals p.ID
                          orderby r.r_time descending
                          select new
                          {
                              r.r_name,
                              p.p_email,
                          }).Take(10);//取前10个结果
            GridView1.DataSource = resultr;
            GridView1.DataBind();
            var resultj = (from j in bsdata.BS_job
                          join c in bsdata.BS_company on j.cID equals c.ID
                          orderby j.j_time descending
                          select new
                          {
                              j.j_name,
                              c.c_name,
                          }).Take(10);
            GridView2.DataSource = resultj;
            GridView2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)/*用户登录按钮*/
        {
            if (Session["PE"] != null || Session["CE"] != null)
            {
                Session.RemoveAll();
            }
            string _uemail = tpemail.Text.Trim().ToString();
            string _upsw = tppsw.Text.Trim().ToString();
            if (RadioButton1.Checked)
            {
                var result = from user in bsdata.BS_person
                             where user.p_email == _uemail && user.p_psw == _upsw
                             select user;
                if (result.Count() > 0)
                {
                    Session["PE"] = _uemail;
                    Session["PID"] = result.First().ID.ToString();
                    Response.Redirect("PRsCenter.aspx");
                }

                else
                {
                    loginerror.Text = "用户名或密码错误";
                }
            }
            else
            {
                var result = from user in bsdata.BS_company
                             where user.c_email == _uemail && user.c_psw == _upsw
                             select user;
                if (result.Count() > 0)
                {
                    Session["CE"] = _uemail;
                    Session["CID"] = result.First().ID.ToString();
                    Response.Redirect("CJobCenter.aspx");
                }

                else
                {
                    loginerror.Text = "用户名或密码错误";
                }
            }

        }


        protected void Button3_Click(object sender, EventArgs e)/*个人用户注册按钮*/
        {
            string _uemail = ztemail.Text.Trim().ToString();
            string _upsw = ztpsw.Text.Trim().ToString();
            var result = from user in bsdata.BS_person
                         where user.p_email == _uemail
                         select user;
            if (result.Count() > 0)
            {
                signerror.Text = "此邮箱已被使用,请换一个试试";
            }
            else
            {
                var newPerson = new BS_person
                {
                    p_email = _uemail,
                    p_psw = _upsw,
                };
                bsdata.BS_person.InsertOnSubmit(newPerson);
                bsdata.SubmitChanges();
                //Response.Redirect("Index.aspx");
                Response.Write("<script>alert('注册成功，请登录');</script>");

            }

        }

        protected void Button2_Click(object sender, EventArgs e)/*企业用户注册按钮*/
        {
            string _uemail = ztemail.Text.Trim().ToString();
            string _upsw = ztpsw.Text.Trim().ToString();
            var result = from user in bsdata.BS_company
                         where user.c_email == _uemail
                         select user;
            if (result.Count() > 0)
            {
                signerror.Text = "此邮箱已被使用,请换一个试试";
            }
            else
            {
                var newCompany = new BS_company
                {
                    c_email = _uemail,
                    c_psw = _upsw,
                };
                bsdata.BS_company.InsertOnSubmit(newCompany);
                bsdata.SubmitChanges();
                Response.Write("<script>alert('注册成功，请登录');</script>");
                //Response.Redirect("Index.aspx");


            }
        }

        protected void Button4_Click(object sender, EventArgs e)/*查询职位*/
        {
           
            string city = TextBox1.Text.Trim().ToString();
            string hangye = TextBox2.Text.Trim().ToString();
            string xinshui = TextBox3.Text.Trim().ToString();
            string jibie = TextBox4.Text.Trim().ToString();
            Response.Redirect("SearchJob.aspx?city="+city+"&hangye="+hangye+"&xinshui="+xinshui+"&jibie="+jibie);
        }
       
    }
}