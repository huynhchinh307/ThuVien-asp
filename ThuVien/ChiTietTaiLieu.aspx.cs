using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class ChiTietTaiLieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("~/Dang-Nhap");
            if (!IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            try
            {
                string id = RouteData.Values["id"].ToString();
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                dataChiTiet.DataSource = truyvan.LaydulieubyID(id, "TaiLieuByID_Select", "IdTaiLieu");
                GridView gr = new GridView();
                gr.DataSource = truyvan.LaydulieubyID(id, "TaiLieuByID_Select", "IdTaiLieu");
                gr.DataBind();
                if (gr.Rows.Count >= 1)
                {
                    dataChiTiet.DataBind();
                }
                else
                {
                    Response.Redirect("~/Tai-Lieu");
                }
            }
            catch
            {
                Response.Redirect("~/Tai-Lieu");
            }


        }
    }
}