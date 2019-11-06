using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public class TheLoaiSachDAO
    {
        public bool ThemTheLoaiSach(TheLoaiSach theLoaiSach)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "TheLoaiSach_Insert";
            sqldata.InsertParameters.Add("TenTheLoaiSach", theLoaiSach.Tentheloai.ToString());


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
        public bool SuaTheLoaiSach(TheLoaiSach theLoaiSach)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "TheLoaiSach_Update";
            sqldata.UpdateParameters.Add("IDTheLoaiSach", theLoaiSach.Idtheloaisach.ToString());
            sqldata.UpdateParameters.Add("TenTheLoaiSach", theLoaiSach.Tentheloai.ToString());

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
        public bool XoaTheLoaiSach(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "TheLoaiSach_Delete";
            sqldata.DeleteParameters.Add("IdTheLoaiSach", id);
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