using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class SuaNguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("QLNguoiDung.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            string username = Request.QueryString["id"];
            NguoiDungDAO DAO = new NguoiDungDAO();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(username, "NguoiDungByID_Select", "UserName");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtUserName.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
                txtTenNguoiDung.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[2].Text.ToString()));
                txtMatKhau.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[3].Text.ToString()));
                txtEmail.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[4].Text.ToString()));
                if (HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[5].Text.ToString())) == "1")
                {
                    drlLevel.Items.Clear();
                    drlLevel.Items.Insert(0, new ListItem("Quản trị viên", "1"));
                    drlLevel.Items.Insert(1, new ListItem("Thành viên", "0"));
                }
                else
                {
                    drlLevel.Items.Clear();
                    drlLevel.Items.Insert(0, new ListItem("Thành viên", "0"));
                    drlLevel.Items.Insert(1, new ListItem("Quản trị viên", "1"));
                }
            }
            else
                Response.Redirect("QLNguoiDung.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string UserName = Request.QueryString["id"];
                string MatKhau = txtMatKhau.Text;
                string TenNguoiDung = txtTenNguoiDung.Text;
                string Email = txtEmail.Text;
                int level = int.Parse(drlLevel.SelectedValue.ToString());
                NguoiDung nguoiDung = new NguoiDung
                {
                    Username = UserName,
                    Tennguoidung = TenNguoiDung,
                    Matkhau = MatKhau,
                    Email = Email,
                    Level= level
                };
                NguoiDungDAO DAO = new NguoiDungDAO();
                if (DAO.SuaNguoiDung(nguoiDung))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Cập nhật thành công.";
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình sửa. Liên hệ DEV";
                }
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLNguoiDung.aspx");
        }
    }
}