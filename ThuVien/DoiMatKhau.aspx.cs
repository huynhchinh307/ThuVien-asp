using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("~/Dang-Nhap");
            }
        }

        protected void btnCapNhat_Click(object sender, ImageClickEventArgs e)
        {
            if(IsValid)
            {
                string NhapMKCu = txtMatKhau.Text;
                string MatKhau = txtMatKhauMoi.Text;
                string MatKhauCu;
                string email;
                string hoten;
                int level;
                GridView gr = new GridView();
                string username = Session["login"].ToString();
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                gr.DataSource = truyvan.LaydulieubyID(username, "NguoiDungByID_Select", "UserName");
                gr.DataBind();
                hoten = HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[2].Text.ToString());
                MatKhauCu= HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[3].Text.ToString());
                email = HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[4].Text.ToString());
                level = int.Parse(gr.Rows[0].Cells[5].Text.ToString());
                NguoiDung nguoiDung = new NguoiDung
                {
                    Username = username,
                    Email = email,
                    Tennguoidung = hoten,
                    Matkhau = MatKhau,
                    Level = level
                };
                NguoiDungDAO DAO = new NguoiDungDAO();
                if (MatKhauCu == NhapMKCu)
                {
                    if (DAO.SuaNguoiDung(nguoiDung))
                    {
                        lblThongBao.Text = "Đổi mật khẩu thành công !";
                    }
                    else
                        lblThongBao.Text = "Có lỗi trong quá trình đổi mật khẩu.";
                }
                else
                    lblThongBao.Text = "Mật khẩu cũ không đúng.";
                
            }
        }
    }
}