using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class QLTheLoaiSach : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            data.DataSource = dao.Laydulieu("TheLoaiSach_Select");
            data.DataBind();
        }
        protected void data_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            data.PageIndex = e.NewPageIndex;   //trang hien tai
            LoadDuLieu();
        }

        protected void data_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sua")
            {
                id = (string)e.CommandArgument;
                Loadform(id);
            }
            else
            {
                id = (string)e.CommandArgument;
                TheLoaiSachDAO DAO = new TheLoaiSachDAO();
                DAO.XoaTheLoaiSach(id);
                LoadDuLieu();
            }
        }
        private void Loadform(string id)
        {
            TheLoaiSach DAO = new TheLoaiSach();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "TheLoaiSachByID_Select", "IdTheLoaiSach");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txttheloaisach1.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
                TextBox1.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
            }

            else
                Response.Redirect("QLTheLoaiSach.aspx");
        }

        protected void ckbChonAll_CheckedChanged(object sender, EventArgs e)
        {
            bool trangthai = false;
            if (ckbChonAll.Checked) trangthai = true;
            foreach (GridViewRow dr in data.Rows)
            {
                CheckBox chk = (CheckBox)dr.Cells[0].FindControl("ckbChon");
                chk.Checked = trangthai;
            }

        }

        protected void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in data.Rows)
            {
                TheLoaiSachDAO DAO = new TheLoaiSachDAO();
                CheckBox ck = (CheckBox)row.FindControl("ckbChon");
                if (ck != null && ck.Checked)
                {
                    string id = row.Cells[1].Text.ToString();
                    if (DAO.XoaTheLoaiSach(id))
                        LoadDuLieu();
                    else
                        Response.Redirect("../Error.aspx");
                }
            }
        }

        protected void btnThem_click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid)
            {
                string tentheloaisach = txtTheLoaiSach.Text;
                TheLoaiSach theLoaiSach = new TheLoaiSach
                {
                    Tentheloai = tentheloaisach
                };
                TheLoaiSachDAO DAO = new TheLoaiSachDAO();
                if (DAO.ThemTheLoaiSach(theLoaiSach))
                {
                    lblThongBao.Text = "Thêm bài viết thành công.";
                    LoadDuLieu();
                }
                else
                {
                    lblThongBao.Text = "Có lỗi trong quá trình thêm. Liên hệ DEV";
                }

            }
        }
            protected void btnSua_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string tentheloaisach = txttheloaisach1.Text;
                TheLoaiSach theLoaiSach = new TheLoaiSach
                {
                    Idtheloaisach = int.Parse(TextBox1.Text),
                    Tentheloai = tentheloaisach
                };
                TheLoaiSachDAO DAO = new TheLoaiSachDAO();
                if (DAO.SuaTheLoaiSach(theLoaiSach))
                {
                    lblThongBao2.Text = "Cập nhật thành công.";
                    LoadDuLieu();
                }
                else
                {
                    lblThongBao2.Text = "Có lỗi trong quá trình sửa. Liên hệ DEV";
                }
            }
        }
    }
}