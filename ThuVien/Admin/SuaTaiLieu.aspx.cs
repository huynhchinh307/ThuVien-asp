using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class SuaTaiLieu : System.Web.UI.Page
    {
        string img;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("QLSach.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }

        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "TaiLieuByID_Select", "IdTaiLieu");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtTieuDe.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
                txtTenFile.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[2].Text.ToString()));
                LoadChuyenNganh();
                Image1.ImageUrl= HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[6].Text.ToString()));
                drpChuyenNganh.Items.FindByValue(gr.Rows[0].Cells[7].Text.ToString()).Selected = true;
                txtMoTa.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[4].Text.ToString()));
            }
            else
                Response.Redirect("QLTaiLieu.aspx");
        }
        public void LoadChuyenNganh()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            drpChuyenNganh.DataValueField = "IdChuyenNganh";
            drpChuyenNganh.DataTextField = "TenChuyenNganh";
            drpChuyenNganh.DataSource = dao.Laydulieu("ChuyenNganh_Select");
            drpChuyenNganh.DataBind();
        }
        bool CheckImgType(string fileName)
        {

            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }
        protected void btnSuaTaiLieu_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string TieuDe = txtTieuDe.Text;
                string TenFile = txtTenFile.Text;
                string MoTa = txtMoTa.Text;
                string id = Request.QueryString["id"];
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                GridView gr = new GridView();
                gr.DataSource = truyvan.LaydulieubyID(id, "TaiLieuByID_Select", "IdTaiLieu");
                gr.DataBind();
                img = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[6].Text.ToString()));
                if (FileUpload1.HasFile && CheckImgType(FileUpload1.FileName))
                {
                    img = "~/Uploads/IMGTaiLieu/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + FileUpload1.FileName;
                    string imgPath = MapPath(img);
                    FileUpload1.SaveAs(imgPath);
                }
                
                string UserName = Session["loginCP"].ToString();
                int IdChuyenNganh = int.Parse(drpChuyenNganh.SelectedValue.ToString());
                TaiLieu taiLieu = new TaiLieu
                {
                    Idtailieu = int.Parse(Request.QueryString["id"]),
                    Tentailieu = TieuDe,
                    MoTa = MoTa,
                    Hinh = img,
                    File = TenFile,
                    Idchuyennganh= IdChuyenNganh
                };
                BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
                if (DAO.SuaTaiLieu(taiLieu))
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
            Response.Redirect("QLTaiLieu.aspx");
        }
    }
}