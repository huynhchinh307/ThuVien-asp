using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TaiKhoan : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("~/Dang-Nhap");
            }
            if(!IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            GridView gr = new GridView();
            string username = Session["login"].ToString();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            gr.DataSource = truyvan.LaydulieubyID(username, "NguoiDungByID_Select", "UserName");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtHoTen.Text = HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[2].Text.ToString());
                txtEmail.Text = HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[4].Text.ToString());
            }
            else
                Response.Redirect("~/Tai-Khoan.aspx");
        }

        protected void btnCapNhat_Click(object sender, ImageClickEventArgs e)
        {
            if (IsValid)
            {
                string email = txtEmail.Text;
                string hoten = txtHoTen.Text;
                string matkhau;
                int level;
                GridView gr = new GridView();
                string username = Session["login"].ToString();
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                gr.DataSource = truyvan.LaydulieubyID(username, "NguoiDungByID_Select", "UserName");
                gr.DataBind();
                //Lay cac thong tin con thieu
                matkhau = HttpUtility.HtmlDecode((string)gr.Rows[0].Cells[3].Text.ToString());
                level = int.Parse(gr.Rows[0].Cells[5].Text.ToString());
                NguoiDung nguoiDung = new NguoiDung
                {
                    Username = username,
                    Email = email,
                    Tennguoidung = hoten,
                    Matkhau = matkhau,
                    Level = level
                };
                NguoiDungDAO DAO = new NguoiDungDAO();
                if (DAO.SuaNguoiDung(nguoiDung))
                {
                    lblThongBao.Text = "Cập nhật thông tin thành công !";
                }
                else
                    lblThongBao.Text = "Có lỗi trong quá trình cập nhật.";
            }
            
        }
    }
}