using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginCP"] != null)
            {
                string NguoiDung = Session["loginCP"].ToString();
                lblUserName.Text = NguoiDung;
            }
            else
                Response.Redirect("Login.aspx");
        }
    }
}