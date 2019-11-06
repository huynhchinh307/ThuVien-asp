using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class Theme : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Active.Visible = false;
            if (Session["login"] != null)
            {
                string NguoiDung =Session["login"].ToString();
                NotActive.Visible = false;
                Active.Visible = true;
                lblHoTen.Text = NguoiDung;
            }
            if(!Page.IsPostBack)
            {
                LoadChuyenNganh();
                LoadTheLoai();
                LoadBaiViet();
            }
        }
        private void LoadChuyenNganh()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataChuyenNganh.DataSource = dao.Laydulieu("ChuyenNganh_Select");
            dataChuyenNganh.DataBind();
        }
        private void LoadTheLoai()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataTheLoai.DataSource = dao.Laydulieu("TheLoai_Select");
            dataTheLoai.DataBind();
        }
        private void LoadBaiViet()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataBaiViet.DataSource = dao.Laydulieu("BaiViet_SelectNew");
            dataBaiViet.DataBind();
        }

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            string key = txtTuKhoa.Text;
            Response.Redirect("TimKiem.aspx?search=" + key);
        }
    }
}