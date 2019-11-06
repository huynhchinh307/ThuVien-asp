using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien.Admin.BusinessLogic
{
    public class TaiLieuDAO
    {
        public bool ThemTaiLieu(TaiLieu taiLieu)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "Tailieu_Insert";
            sqldata.InsertParameters.Add("TenTaiLieu", taiLieu.Tentailieu.ToString());
            sqldata.InsertParameters.Add("UserName", taiLieu.UserName.ToString());
            sqldata.InsertParameters.Add("TenFile", taiLieu.File.ToString());
            sqldata.InsertParameters.Add("IdChuyenNganh", taiLieu.Idchuyennganh.ToString());
            sqldata.InsertParameters.Add("Hinh", taiLieu.Hinh.ToString());
            sqldata.InsertParameters.Add("MoTa", taiLieu.MoTa.ToString());
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
            sqldata.UpdateCommand = "DuyetTaiLieu";
            sqldata.UpdateParameters.Add("IdTaiLieu", id.ToString());
            sqldata.Update();
        }
        public bool SuaTaiLieu(TaiLieu taiLieu)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "TaiLieu_Update";
            sqldata.UpdateParameters.Add("IdTaiLieu", taiLieu.Idtailieu.ToString());
            sqldata.UpdateParameters.Add("TenTaiLieu", taiLieu.Tentailieu.ToString());
            sqldata.UpdateParameters.Add("IdChuyenNganh", taiLieu.Idchuyennganh.ToString());
            sqldata.UpdateParameters.Add("TenFile", taiLieu.File.ToString());
            sqldata.UpdateParameters.Add("MoTa", taiLieu.MoTa.ToString());
            sqldata.UpdateParameters.Add("Hinh", taiLieu.Hinh.ToString());
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
        public bool XoaTaiLieu(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "TaiLieu_Delete";
            sqldata.DeleteParameters.Add("IdTaiLieu", id);
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