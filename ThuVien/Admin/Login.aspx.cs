using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["login"] != null)
            //{
            //    Response.Redirect("Default.aspx");
            //}
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string user = txtUserName.Text;
                string pass = txtMatKhau.Text;
                NguoiDungDAO dao = new NguoiDungDAO();
                if (dao.CheckAdmin(user, pass))
                {
                    Session["loginCP"] = user;
                    Response.Redirect("index.aspx");
                }
                else
                    lblthongbao.Text = "Đăng nhập thất bại";
            }

        }

        protected void ckbhien_CheckedChanged(object sender, EventArgs e)
        {
            string pass = txtMatKhau.Text;
            if (ckbhien.Checked)
            {
                txtMatKhau.TextMode = TextBoxMode.SingleLine;
                txtMatKhau.Text = pass;
            }
            else
            {
                txtMatKhau.TextMode = TextBoxMode.Password;
                txtMatKhau.Text = pass;
            }
        }
    }
}