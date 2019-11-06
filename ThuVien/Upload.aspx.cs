using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("~/Dang-Nhap");
            }
            if (!IsPostBack)
            {
                upload.ActiveViewIndex = 0;
                LoadTheLoai();
                LoadNhaXuatBan();
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

        protected void btnUploadSach_Click(object sender, ImageClickEventArgs e)
        {
            if(Page.IsValid && fHinh.HasFile && fSach.HasFile && CheckImgType(fHinh.FileName) && CheckFileType(fSach.FileName))
            {
                string imgName = "~/Uploads/IMGSach/"+DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + fHinh.FileName;
                string imgPath = MapPath(imgName);
                fHinh.SaveAs(imgPath);
                imgHinh.ImageUrl = imgName;
                string fileName = "~/Uploads/files/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + fSach.FileName;
                string filePath = MapPath(fileName);
                fSach.SaveAs(filePath);
                Sach sach = new Sach
                {
                    TenSach = txtTenSach.Text,
                    Tacgia = txtTacGia.Text,
                    MoTa = txtMoTaSach.Text,
                    Idnhaxuatban = int.Parse(drpNhaXuatBan.SelectedValue.ToString()),
                    Idtheloaisach = int.Parse(drpTheLoaiSach.SelectedValue.ToString()),
                    UserName = Session["login"].ToString(),
                    Hinh = imgName,
                    File = fileName
                };
                SachDAO DAO = new SachDAO();
                if(DAO.ThemSach(sach))
                {
                    lblThongBao.Text = "Tải lên thành công. Sách của bạn đang trong quá trình xem xét";
                }
                else
                {
                    lblThongBao.Text = "Có lỗi trong quá trình tải lên. Liên hệ quản trị viên";
                }
                
            }
            else
            {
                lblThongBao.Text="Định dạng upload không hợp lệ";
            }
        }

        protected void btnViewSach_Click(object sender, ImageClickEventArgs e)
        {
            upload.ActiveViewIndex = 0;
            LoadTheLoai();
            LoadNhaXuatBan();
        }

        protected void btnViewTaiLieu_Click(object sender, ImageClickEventArgs e)
        {
            upload.ActiveViewIndex = 1;
            LoadChuyenNganh();
        }

        protected void btnTaiLieu_Click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid && fHinh2.HasFile && fTaiLieu.HasFile && CheckImgType(fHinh2.FileName) && CheckFileType(fTaiLieu.FileName))
            {
                string imgName = "Uploads/IMGTaiLieu/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_")+"ThuVien_" + fHinh2.FileName;
                string imgPath = MapPath(imgName);
                fHinh2.SaveAs(imgPath);
                imgHinh2.ImageUrl = imgName;
                string fileName = "Uploads/files/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_")+"ThuVien_" + fTaiLieu.FileName;
                string filePath = MapPath(fileName);
                fTaiLieu.SaveAs(filePath);
                Admin.TaiLieu taiLieu = new Admin.TaiLieu
                {
                    Tentailieu = txtTenTaiLieu.Text,
                    Idchuyennganh = int.Parse(drpChuyenNganh.SelectedValue.ToString()),
                    MoTa = txtMoTaTaiLieu.Text,
                    UserName = Session["login"].ToString(),
                    Hinh = imgName,
                    File = fileName,
                };
                Admin.BusinessLogic.TaiLieuDAO DAO = new Admin.BusinessLogic.TaiLieuDAO();
                if (DAO.ThemTaiLieu(taiLieu))
                {
                    lblThongBao.Text = "Tải lên thành công. Tài liệu của bạn đang trong quá trình xem xét";
                }
                else
                {
                    lblThongBao.Text = "Có lỗi trong quá trình tải lên. Liên hệ quản trị viên";
                }

            }
            else
            {
                lblThongBao.Text = "Định dạng upload không hợp lệ";
            }
        }
    }
}