using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class TaiLieuCuaToi : System.Web.UI.Page
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
            dataTaiLieuCuaToi.DataSource = truyvan.LaydulieubyID(username, "TaiLieuCuaToi", "UserName");
            dataTaiLieuCuaToi.DataBind();
        }

        protected void dataTaiLieuCuaToi_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow){
                TableCell TrangThai = e.Row.Cells[3];
                int TT = int.Parse(TrangThai.Text);
                if (TT == 1)
                {
                    TrangThai.Text = "Đã duyệt";
                }
                else
                    TrangThai.Text = "Đang duyệt";
            }
        }
        protected void dataTaiLieuCuaToi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataTaiLieuCuaToi.PageIndex = e.NewPageIndex;   //trang hien tai
            LoadDuLieu();
        }
        protected void dataTaiLieuCuaToi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                string id = (string)e.CommandArgument;
                Admin.BusinessLogic.TaiLieuDAO DAO = new Admin.BusinessLogic.TaiLieuDAO();
                DAO.XoaTaiLieu(id);
                LoadDuLieu();
            }
        }
    }
}