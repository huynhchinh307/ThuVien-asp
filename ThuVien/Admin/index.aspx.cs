using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class index : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LoadSach();
                LoadTaiLieu();
            }
                
        }
        private void LoadSach()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataSach.DataSource = dao.Laydulieu("SachChuaDuyet_Select");
            dataSach.DataBind();
        }
        private void LoadTaiLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataTaiLieu.DataSource = dao.Laydulieu("TaiLieuChuaDuyet_Select");
            dataTaiLieu.DataBind();
        }
        protected void dataSach_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataSach.PageIndex = e.NewPageIndex;   //trang hien tai
            LoadSach();
        }
        protected void dataTaiLieu_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dataTaiLieu.PageIndex = e.NewPageIndex;   //trang hien tai
            LoadTaiLieu();
        }
        protected void dataSach_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duyet")
            {
                id = (string)e.CommandArgument;
                SachDAO DAO = new SachDAO();
                DAO.Duyet(id);
                LoadSach();
            }
        }
        protected void dataTaiLieu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Duyet")
            {
                id = (string)e.CommandArgument;
                BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
                DAO.Duyet(id);
                LoadTaiLieu();
            }
        }
    }
}