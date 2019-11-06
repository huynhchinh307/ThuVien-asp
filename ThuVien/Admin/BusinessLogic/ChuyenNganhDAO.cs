using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien.Admin
{
    public class ChuyenNganhDAO
    {
        public bool ThemChuyenNganh(ChuyenNganh chuyenNganh)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "ChuyenNganh_Insert";
            sqldata.InsertParameters.Add("TenChuyenNganh", chuyenNganh.Tenchuyennganh.ToString());
         

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
        public bool SuaChuyeNganh(ChuyenNganh chuyenNganh)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "ChuyenNganh_Update";
            sqldata.UpdateParameters.Add("IDChuyenNganh", chuyenNganh.Idchuyennganh.ToString());
            sqldata.UpdateParameters.Add("TenChuyenNganh", chuyenNganh.Tenchuyennganh.ToString());
           
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
        public bool XoaChuyenNganh(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "ChuyenNganh_Delete";
            sqldata.DeleteParameters.Add("IdChuyenNganh", id);
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