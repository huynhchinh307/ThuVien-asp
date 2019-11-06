using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public class NhaXuatBanDAO
    {
        public bool ThemNhaXuatBan(NhaXuatBan nhaXuatBan)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "NhaXuatBan_Insert";
            sqldata.InsertParameters.Add("TenNhaXuatBan", nhaXuatBan.Tennhaxuatban.ToString());


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
        public bool SuaNhaXuatBan(NhaXuatBan nhaXuatBan)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "NhaXuatBan_Update";
            sqldata.UpdateParameters.Add("IdNhaXuatBan", nhaXuatBan.Idnhaxuatban.ToString());
            sqldata.UpdateParameters.Add("TenNhaXuatBan", nhaXuatBan.Tennhaxuatban.ToString());

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
        public bool XoaNhaXuatBan(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "NhaXuatBan_Delete";
            sqldata.DeleteParameters.Add("IdNhaXuatBan", id);
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