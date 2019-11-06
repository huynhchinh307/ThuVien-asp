using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public partial class ThemBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangBai_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DateTime ngayDang = DateTime.Now;
                string TieuDe = txtTieuDe.Text;
                string NoiDung = txtNoiDung.Text;
                string UserName = Session["loginCP"].ToString();
                BaiViet baiViet = new BaiViet
                {
                    Tenbaiviet = TieuDe,
                    Noidung = NoiDung,
                    Thoigian = ngayDang,
                    UserName = UserName
                };
                BaiVietDAO DAO = new BaiVietDAO();
                if (DAO.ThemBaiViet(baiViet))
                {
                    thongbao.Attributes.Add("class", "msg msg-ok");
                    lblThongBao.Text = "Thêm bài viết thành công.";
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
    }
}