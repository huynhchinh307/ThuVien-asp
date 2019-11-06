using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] == null)
                Response.Redirect("/");
            if (!IsPostBack)
            {
                LoadSach();
                LoadTaiLieu();
            }
        }
        private void LoadSach()
        {
            string key = Request.QueryString["search"].ToString();
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            kqSach.DataSource = dao.LaydulieubyID(key, "SachSearch_Select", "key");
            kqSach.DataBind();
        }
        private void LoadTaiLieu()
        {
            string key = Request.QueryString["search"].ToString();
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            kqTaiLieu.DataSource = dao.LaydulieubyID(key, "TaiLieuSearch_Select", "key");
            kqTaiLieu.DataBind();
        }
    }
}