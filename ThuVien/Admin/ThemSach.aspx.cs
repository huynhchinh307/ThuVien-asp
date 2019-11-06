using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class ThemSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadNhaXuatBan();
            LoadTheLoai();
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
        bool CheckFileType(string fileName)
        {

            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".doc":
                    return true;
                case ".pdf":
                    return true;
                case ".docx":
                    return true;
                default:
                    return false;
            }
        }
        protected void btnDangSach_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && fhinh.HasFile && ffile.HasFile && CheckImgType(fhinh.FileName) && CheckFileType(ffile.FileName))
            {              
                string TieuDe = txtTieuDe.Text;
                string TacGia = txtTacGia.Text;
                string MoTa = txtMoTa.Text;
                string imgName = "~/Uploads/IMGTaiLieu/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + fhinh.FileName;
                string imgPath = MapPath(imgName);
                fhinh.SaveAs(imgPath);
                string fileName = "~/Uploads/files/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + ffile.FileName;
                string filePath = MapPath(fileName);
                ffile.SaveAs(filePath);
                string Username = Session["loginCP"].ToString();
                int Idnhaxuatban = int.Parse(drpNhaXuatBan.SelectedValue.ToString());
                int Idtheloaisach = int.Parse(drpTheLoaiSach.SelectedValue.ToString());
                Sach sach = new Sach
                {
                    TenSach = TieuDe,
                    Tacgia = TacGia,
                    MoTa = MoTa,
                    File = fileName,
                    UserName = Username,
                    Idnhaxuatban = Idnhaxuatban,
                    Idtheloaisach = Idtheloaisach,
                    Hinh = imgName
                };
                SachDAO DAO = new SachDAO();
                if (DAO.ThemSach(sach))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Thêm bài sách thành công.";
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình thêm. Liên hệ DEV";
                }

            }

        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {

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