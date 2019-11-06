using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class QLChuyenNganh : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("QLChuyenNganh.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
            
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            data.DataSource = dao.Laydulieu("ChuyenNganh_Select");
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
                ChuyenNganhDAO DAO = new ChuyenNganhDAO();
                DAO.XoaChuyenNganh(id);
                LoadDuLieu();
            }
        }
        private void Loadform(string id)
        {
            ChuyenNganhDAO DAO = new ChuyenNganhDAO();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "ChuyenNganhByID_Select", "IdChuyenNganh");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtChuyenNganh1.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
                TextBox1.Text= HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
            }
            
            else
                Response.Redirect("QLChuyenNganh.aspx");
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
                ChuyenNganhDAO DAO = new ChuyenNganhDAO();
                CheckBox ck = (CheckBox)row.FindControl("ckbChon");
                if (ck != null && ck.Checked)
                {
                    string id = row.Cells[1].Text.ToString();
                    if (DAO.XoaChuyenNganh(id))
                        LoadDuLieu();
                    else
                        Response.Redirect("../Error.aspx");
                }
            }
        }

        protected void btn(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnThem_click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid)
            {
                string tenchuyennganh = txtTenChuyenNganh.Text;
                ChuyenNganh chuyenNganh = new ChuyenNganh
                {
                    Tenchuyennganh = tenchuyennganh
                };
                ChuyenNganhDAO DAO = new ChuyenNganhDAO();
                if (DAO.ThemChuyenNganh(chuyenNganh))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Thêm bài viết thành công.";
                    LoadDuLieu();
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình thêm. Liên hệ DEV";
                }

            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string tenchuyennganh = txtChuyenNganh1.Text;
                ChuyenNganh chuyenNganh = new ChuyenNganh
                {
                    Idchuyennganh = int.Parse(TextBox1.Text),
                    Tenchuyennganh = tenchuyennganh
                };
                ChuyenNganhDAO DAO = new ChuyenNganhDAO();
                if (DAO.SuaChuyeNganh(chuyenNganh))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Cập nhật thành công.";
                    LoadDuLieu();
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình sửa. Liên hệ DEV";
                }
            }
        }
    }
}