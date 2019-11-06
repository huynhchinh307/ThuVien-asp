using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace ThuVien
{
    public class Global : System.Web.HttpApplication
    {
        void Url(RouteCollection routes)
        {
            routes.MapPageRoute("Trang chủ", "", "~/index.aspx");
            routes.MapPageRoute("Đăng nhập", "Dang-nhap", "~/DangNhap.aspx");
            routes.MapPageRoute("Đăng ký", "Dang-Ky", "~/DangKy.aspx");
            routes.MapPageRoute("Đăng xuất", "exit", "~/Exit.aspx");
            routes.MapPageRoute("Tài khoản", "Tai-Khoan", "~/TaiKhoan.aspx");
            routes.MapPageRoute("Đổi mật khẩu", "Doi-Mat-Khau", "~/DoiMatKhau.aspx");
            routes.MapPageRoute("Upload", "Upload", "~/Upload.aspx");
            routes.MapPageRoute("Sách", "Sach", "~/Sach.aspx");
            routes.MapPageRoute("Tài liệu", "Tai-Lieu", "~/TaiLieu.aspx");
            routes.MapPageRoute("Tin tức", "Tin-Tuc", "~/BaiViet.aspx");
            routes.MapPageRoute("Giới Thiệu", "Gioi-Thieu", "~/ChiTietBaiViet.aspx?id=BV001");
            routes.MapPageRoute("Thể loại sách", "Sach/TL/{name}-{id}", "~/TheLoai.aspx");
            routes.MapPageRoute("Danh Mục tài liệu", "Tai-Lieu/DM/{name}-{id}", "~/ChuyenNganh.aspx");
            routes.MapPageRoute("Tin tức chi tiết", "Tin-Tuc/{name}-{id}", "~/ChiTietBaiViet.aspx");
            routes.MapPageRoute("Hiển thị chi tiết", "Sach/{name}-{id}", "~/ChiTietSach.aspx");
            routes.MapPageRoute("Tài liệu chi tiết", "Tai-Lieu/{name}-{id}", "~/ChiTietTaiLieu.aspx");
            routes.MapPageRoute("Tài liệu của tôi", "Tai-Khoan/tai-lieu-cua-toi", "~/TaiLieuCuaToi.aspx");
            routes.MapPageRoute("Sách của tôi", "Tai-Khoan/sach-cua-toi", "~/SachCuaToi.aspx");
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            Url(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}