using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace ThuVien
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                Response.Redirect("/");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                NguoiDungDAO DAO = new NguoiDungDAO();
                string TenNguoiDung = txtTenDangNhap.Text;
                string Matkhau = txtMatKhau.Text;
                if (DAO.CheckLogin(TenNguoiDung, Matkhau))
                {
                    Session["Login"] = txtTenDangNhap.Text;
                    Response.Redirect("/");
                }
                else
                {
                    lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                }
            }
        }
    }
}