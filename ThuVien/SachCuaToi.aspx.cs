using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class SachCuaToi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("~/Dang-Nhap");
            }
            if (!IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            string username = Session["login"].ToString();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            dataSachCuaToi.DataSource = truyvan.LaydulieubyID(username, "SachCuaToi", "UserName");
            dataSachCuaToi.DataBind();
        }

        protected void dataSachCuaToi_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCell TrangThai = e.Row.Cells[5];
                int TT = int.Parse(TrangThai.Text);
                if (TT == 1)
                {
                    TrangThai.Text = "Đã duyệt";
                }
                else
                    TrangThai.Text = "Đang duyệt";
            }
        }
        protected void dataSachCuaToi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataSachCuaToi.PageIndex = e.NewPageIndex;   //trang hien tai
            LoadDuLieu();
        }
        protected void dataSachCuaToi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                string id = (string)e.CommandArgument;
                SachDAO DAO = new SachDAO();
                DAO.XoaSach(id);
                LoadDuLieu();
            }
            else
                Response.Redirect("aaaaaaaaaâ");
        }
    }
}