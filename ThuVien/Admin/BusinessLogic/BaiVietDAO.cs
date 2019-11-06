using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public class BaiVietDAO
    {
        public bool ThemBaiViet(BaiViet baiViet)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "BaiViet_Insert";
            sqldata.InsertParameters.Add("TenBaiViet", baiViet.Tenbaiviet.ToString());
            sqldata.InsertParameters.Add("NoiDung", baiViet.Noidung.ToString());
            sqldata.InsertParameters.Add("ThoiGian",baiViet.Thoigian.Date.ToString("MM/dd/yyyy"));
            sqldata.InsertParameters.Add("UserName", baiViet.UserName.ToString());
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
        public bool SuaBaiViet(BaiViet baiViet)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "BaiViet_Update";
            sqldata.UpdateParameters.Add("IDBaiViet", baiViet.Idbaiviet.ToString());
            sqldata.UpdateParameters.Add("TenBaiViet", baiViet.Tenbaiviet.ToString());
            sqldata.UpdateParameters.Add("NoiDung", baiViet.Noidung.ToString());
            sqldata.UpdateParameters.Add("ThoiGian", baiViet.Thoigian.Date.ToString("MM/dd/yyyy"));
            sqldata.UpdateParameters.Add("UserName", baiViet.UserName.ToString());
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
        public bool XoaBaiViet(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "BaiViet_Delete";
            sqldata.DeleteParameters.Add("IdBaiViet", id);
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