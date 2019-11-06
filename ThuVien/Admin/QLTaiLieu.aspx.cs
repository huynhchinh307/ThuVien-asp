using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class QLTaiLieu : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            data.DataSource = dao.Laydulieu("TaiLieu_SelectAll");
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
                Response.Redirect("SuaTaiLieu.aspx?id=" + id);
            }
            else
            {
                id = (string)e.CommandArgument;
                BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
                DAO.XoaTaiLieu(id);
                LoadDuLieu();
            }
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
                BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
                CheckBox ck = (CheckBox)row.FindControl("ckbChon");
                if (ck != null && ck.Checked)
                {
                    string id = row.Cells[1].Text.ToString();
                    if (DAO.XoaTaiLieu(id))
                        LoadDuLieu();
                    else
                        Response.Redirect("../Error.aspx");
                }
            }
        }
    }
}