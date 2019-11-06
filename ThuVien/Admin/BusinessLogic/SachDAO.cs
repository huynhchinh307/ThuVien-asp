using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public class SachDAO
    {
        public bool ThemSach(Sach sach)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "Sach_Insert";
            sqldata.InsertParameters.Add("TenSach", sach.TenSach.ToString());
            sqldata.InsertParameters.Add("TacGia", sach.Tacgia.ToString());
            sqldata.InsertParameters.Add("IdTheLoaiSach", sach.Idtheloaisach.ToString());
            sqldata.InsertParameters.Add("IdNhaXuatBan", sach.Idnhaxuatban.ToString());
            sqldata.InsertParameters.Add("Hinh", sach.Hinh.ToString());
            sqldata.InsertParameters.Add("TenFile", sach.File.ToString());
            sqldata.InsertParameters.Add("MoTa", sach.MoTa.ToString());
            sqldata.InsertParameters.Add("UserName", sach.UserName.ToString());
            try
            {
                sqldata.Insert();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Duyet(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "DuyetSach";
            sqldata.UpdateParameters.Add("IDSach", id.ToString());
            sqldata.Update();
        }
        public bool SuaSach(Sach sach)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "Sach_Update";
            sqldata.UpdateParameters.Add("IDSach", sach.Idsach.ToString());
            sqldata.UpdateParameters.Add("TenSach", sach.TenSach.ToString());
            sqldata.UpdateParameters.Add("TacGia", sach.Tacgia.ToString());
            sqldata.UpdateParameters.Add("IDTheLoaiSach", sach.Idtheloaisach.ToString());
            sqldata.UpdateParameters.Add("IDNhaXuatBan", sach.Idnhaxuatban.ToString());
            sqldata.UpdateParameters.Add("TenFile", sach.File.ToString());
            sqldata.UpdateParameters.Add("MoTa", sach.MoTa.ToString());
            sqldata.UpdateParameters.Add("Hinh", sach.Hinh.ToString());
            try
            {
                sqldata.Update();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaSach(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "Sach_Delete";
            sqldata.DeleteParameters.Add("IdSach", id);
            try
            {
                sqldata.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}