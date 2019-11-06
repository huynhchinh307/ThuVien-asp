using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class ChiTietBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            try
            {
                string id = RouteData.Values["id"].ToString();
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                dataBaiViet.DataSource = truyvan.LaydulieubyID(id, "BaiVietByID_Select", "IdBaiViet");
                GridView gr = new GridView();
                gr.DataSource = truyvan.LaydulieubyID(id, "BaiVietByID_Select", "IdBaiViet");
                gr.DataBind();
                if (gr.Rows.Count >= 1)
                {
                    dataBaiViet.DataBind();
                }
                else
                {
                    Response.Redirect("~/Tin-Tuc");
                }
            }
            catch
            {
                Response.Redirect("~/Tin-Tuc");
            }
            
                
        }
    }
}