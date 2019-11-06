using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class ThemNguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                string UserName = txtUserName.Text;
                string PassWord = txtMatKhau.Text;
                string TenNguoiDung = txtTenNguoiDung.Text;
                string Email = txtEmail.Text;
                int level = int.Parse(drlLevel.SelectedValue.ToString());
                NguoiDung nguoiDung = new NguoiDung
                {
                    Username = UserName,
                    Matkhau = PassWord,
                    Tennguoidung = TenNguoiDung,
                    Email = Email,
                    Level = level
                };
                NguoiDungDAO DAO = new NguoiDungDAO();
                if (DAO.ThemNguoiDung(nguoiDung))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Thêm người dùng thành công.";
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Người dùng có tên này đã tồn tại trong hệ thống";
                }
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLNguoiDung.aspx");
        }
    }
}