using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TaiLieu : System.Web.UI.Page
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
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataTaiLieu.DataSource = dao.Laydulieu("Tailieu_Select");
            dataTaiLieu.DataBind();
        }
    }
}