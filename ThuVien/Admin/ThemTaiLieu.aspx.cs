using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class ThemTaiLieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
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
        protected void btnDangTaiLieu_Click(object sender, EventArgs e)
        {

            if (Page.IsValid && fhinh.HasFile && ffile.HasFile && CheckImgType(fhinh.FileName) && CheckFileType(ffile.FileName))
            {
                string TieuDe = txtTieuDe.Text;
                string MoTa = txtMoTa.Text;
                string imgName = "~/Uploads/IMGTaiLieu/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + fhinh.FileName;
                string imgPath = MapPath(imgName);
                fhinh.SaveAs(imgPath);
                string fileName = "~/Uploads/files/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + "ThuVien_" + ffile.FileName;
                string filePath = MapPath(fileName);
                ffile.SaveAs(filePath);
                string Username = Session["loginCP"].ToString();
                int IdChuyenNganh = int.Parse(drpChuyenNganh.SelectedValue.ToString());
              
                TaiLieu taiLieu = new TaiLieu
                {
                    
                    Tentailieu = TieuDe,
                    MoTa = MoTa,
                    File = fileName,
                    UserName = Username,
                    Idchuyennganh = IdChuyenNganh,
                    Hinh = imgName

                };
                BusinessLogic.TaiLieuDAO DAO = new BusinessLogic.TaiLieuDAO();
                if (DAO.ThemTaiLieu(taiLieu))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Thêm tài liệu thành công.";
                }
                else
                {
                    thongbao.Attributes.Add("class", "msg msg-error");
                    lblThongBao.Text = "Có lỗi trong quá trình thêm. Liên hệ DEV";
                }

            }
            else
            {
                lblThongBao.Text = "Định dạng upload không hợp lệ";
            }

        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {

        }
        public void LoadChuyenNganh()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            drpChuyenNganh.DataValueField = "IdChuyenNganh";
            drpChuyenNganh.DataTextField = "TenChuyenNganh";
            drpChuyenNganh.DataSource = dao.Laydulieu("ChuyenNganh_Select");
            drpChuyenNganh.DataBind();
        }
    }
}