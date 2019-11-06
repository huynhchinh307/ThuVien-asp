using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class QLNguoiDung : System.Web.UI.Page
    {
        string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            data.DataSource = dao.Laydulieu("NguoiDung_Select");
            data.DataBind();
        }

        protected void data_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            data.PageIndex = e.NewPageIndex;
            LoadDuLieu();
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
        protected void data_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sua")
            {
                username = (string)e.CommandArgument;
                Response.Redirect("SuaNguoiDung.aspx?id=" + username);
            }
            else
            {
                username = (string)e.CommandArgument;
                NguoiDungDAO DAO = new NguoiDungDAO();
                if(DAO.XoaNguoiDung(username))
                    LoadDuLieu();
                else
                    Response.Redirect("../Error.aspx");
            }
        }
        protected void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in data.Rows)
            {
                NguoiDungDAO DAO = new NguoiDungDAO();
                CheckBox ck = (CheckBox)row.FindControl("ckbChon");
                if (ck != null && ck.Checked)
                {
                    string username = row.Cells[2].Text.ToString();
                    if (DAO.XoaNguoiDung(username))
                        LoadDuLieu();
                    else
                        Response.Redirect("../Error.aspx");
                }
            }
        }
    }
}