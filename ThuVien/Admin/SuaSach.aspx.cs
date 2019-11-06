using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class SuaSach : System.Web.UI.Page
    {
        string img;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("QLSach.aspx");
            if (!this.IsPostBack)
            {
                LoadTheLoai();
                LoadNhaXuatBan();
                LoadDuLieu();
            }

        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            SachDAO DAO = new SachDAO();
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "Sach_SelectID", "IdSach");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                LoadNhaXuatBan();
                LoadTheLoai();
                drpNhaXuatBan.Items.FindByValue(gr.Rows[0].Cells[11].Text.ToString()).Selected = true;
                drpTheLoaiSach.Items.FindByValue(gr.Rows[0].Cells[10].Text.ToString()).Selected = true;
                txtTieuDe.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
                txtTacGia.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[2].Text.ToString()));
                txtTenFile.Text = gr.Rows[0].Cells[6].Text.ToString();
                txtMoTa.Text = gr.Rows[0].Cells[9].Text.ToString();
                Image1.ImageUrl= HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[3].Text.ToString()));
                //  drpNhaXuatBan.SelectedValue.ToString() = gr.Rows[0].Cells[5].Text.ToString();
            }
            else
                Response.Redirect("QLSach.aspx");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLSach.aspx");
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
        protected void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                string TieuDe = txtTieuDe.Text;
                string TacGia = txtTacGia.Text;
                string TenFile = txtTenFile.Text;
                string MoTa = txtMoTa.Text;
                string id = Request.QueryString["id"];
                TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
                GridView gr = new GridView();
                gr.DataSource = truyvan.LaydulieubyID(id, "Sach_SelectID", "IdSach");
                gr.DataBind();
                img = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[3].Text.ToString()));
                if (FileUpload1.HasFile && CheckImgType(FileUpload1.FileName))
                {
                    img = "~/Uploads/Sach/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + FileUpload1.FileName;
                    string imgPath = MapPath(img);
                    FileUpload1.SaveAs(imgPath);
                }
                string UserName = Session["loginCP"].ToString();
                int Idnhaxuatban = int.Parse(drpNhaXuatBan.SelectedValue.ToString());
                int Idtheloaisach = int.Parse(drpTheLoaiSach.SelectedValue.ToString());
                Sach sach = new Sach
                {
                    Idsach = int.Parse(Request.QueryString["id"]),
                    TenSach = TieuDe,
                    Tacgia = TacGia,
                    Idnhaxuatban = Idnhaxuatban,
                    Idtheloaisach= Idtheloaisach,
                    MoTa = MoTa,
                    Hinh = img,
                    File = TenFile,
                };
                SachDAO DAO = new SachDAO();
                if (DAO.SuaSach(sach))
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
        public void LoadTheLoai()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            drpTheLoaiSach.DataTextField = "TenTheLoai";
            drpTheLoaiSach.DataValueField = "IdTheLoaiSach";
            drpTheLoaiSach.DataSource = dao.Laydulieu("TheLoai_Select");
            drpTheLoaiSach.DataBind();


        }
        public void LoadNhaXuatBan()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            drpNhaXuatBan.DataValueField = "IdNhaXuatBan";
            drpNhaXuatBan.DataTextField = "TenNhaXuatBan";
            drpNhaXuatBan.DataSource = dao.Laydulieu("NhaXuatBan_Select");
            drpNhaXuatBan.DataBind();
        }
    }
}