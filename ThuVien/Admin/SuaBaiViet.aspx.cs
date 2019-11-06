using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class SuaBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["id"]==null)
                Response.Write("QLBaiViet.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            NguoiDungDAO DAO = new NguoiDungDAO();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "BaiVietByID_Select", "IdBaiViet");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtTieuDe.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
                txtNoiDung.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
            }
            else
                Response.Redirect("QLBaiViet.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                DateTime ngayDang = DateTime.Now;
                string TieuDe = txtTieuDe.Text;
                string NoiDung = txtNoiDung.Text;
                string UserName = Session["loginCP"].ToString();
                BaiViet baiViet = new BaiViet
                {
                    Idbaiviet = Request.QueryString["id"],
                    Tenbaiviet = TieuDe,
                    Noidung = NoiDung,
                    Thoigian = ngayDang,
                    UserName = UserName
                };
                BaiVietDAO DAO = new BaiVietDAO();
                if (DAO.SuaBaiViet(baiViet))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Cập nhật thành công.";
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình sửa. Liên hệ DEV";
                }
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLBaiViet.aspx");
        }
    }
}