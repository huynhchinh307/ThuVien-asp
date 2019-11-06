using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class ChuyenNganh1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            try
            {
                string i = RouteData.Values["id"].ToString();
                TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
                dataTaiLieu.DataSource = dao.LaydulieubyID(i, "TaiLieuByChuyenNganh_Select", "IdChuyenNganh");
                dataTaiLieu.DataBind();
            }
            catch
            {
                Response.Redirect("/");
            }
        }
    }
}