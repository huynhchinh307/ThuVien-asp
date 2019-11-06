using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TheLoai : System.Web.UI.Page
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
                dataSach.DataSource = dao.LaydulieubyID(i, "SachByTheLoai_Select", "IdTheLoai");
                dataSach.DataBind();
            }
            catch
            {
                Response.Redirect("/");
            }
        }
    }
}