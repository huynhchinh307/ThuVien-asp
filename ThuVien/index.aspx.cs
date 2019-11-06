using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LoadTaiLieuMoiNhat();
                LoadSachMoiNhat();
            }
        }
        private void LoadTaiLieuMoiNhat()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataTaiLieuMoi.DataSource = dao.Laydulieu("TaiLieu_SelectNew");
            dataTaiLieuMoi.DataBind();
        }
        private void LoadSachMoiNhat()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataSachMoi.DataSource = dao.Laydulieu("Sach_SelectNew");
            dataSachMoi.DataBind();
        }
    }
}