using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public class NguoiDungDAO
    {
        public bool CheckAdmin(string user, string pass)
        {
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string sql = @"select count(*) from NguoiDung where UserName = @user and MatKhau = @pass and Level = 1";
            ketNoi.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, ketNoi.LayKetNoi);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            int result = (int)cmd.ExecuteScalar();
            return (result >= 1);
        }
        public bool CheckLogin(string user, string pass)
        {
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string sql = @"select count(*) from NguoiDung where UserName = @user and MatKhau = @pass";
            ketNoi.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, ketNoi.LayKetNoi);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            int result = (int)cmd.ExecuteScalar();
            return (result >= 1);
        }
        public bool ThemNguoiDung(NguoiDung Nguoidung)
        {
                SqlDataSource sqldata = new SqlDataSource();
                KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
                sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
                sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
                sqldata.InsertCommand = "NguoiDung_Insert";
                sqldata.InsertParameters.Add("Username", Nguoidung.Username.ToString());
                sqldata.InsertParameters.Add("Tennguoidung", Nguoidung.Tennguoidung.ToString());
                sqldata.InsertParameters.Add("MatKhau", Nguoidung.Matkhau.ToString());
                sqldata.InsertParameters.Add("Email", Nguoidung.Email.ToString());
            try {
                sqldata.Insert();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaNguoiDung(NguoiDung nguoiDung)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "NguoiDung_Update";
            sqldata.UpdateParameters.Add("UserName", nguoiDung.Username.ToString());
            sqldata.UpdateParameters.Add("TenNguoiDung", nguoiDung.Tennguoidung.ToString());
            sqldata.UpdateParameters.Add("MatKhau", nguoiDung.Matkhau.ToString());
            sqldata.UpdateParameters.Add("Email", nguoiDung.Email.ToString());
            sqldata.UpdateParameters.Add("Level", nguoiDung.Level.ToString());
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
        public bool XoaNguoiDung(string username)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "NguoiDung_Delete";
            sqldata.DeleteParameters.Add("UserName", username);
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