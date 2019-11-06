using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public class TruyVanLayDuLieu
    {
        private ChuyenNganh _chuyennganh;
        public ChuyenNganh Chuyennganh
        {
            get { return _chuyennganh; }
            set { _chuyennganh = value; }
        }
        private NhaXuatBan _nhaxuatban;
        public NhaXuatBan NhaXuatBan
        {
            get { return _nhaxuatban; }
            set { _nhaxuatban = value; }
        }
        public SqlDataSource Laydulieu(string procedue)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = procedue;
            return sqldata;
        }
        public SqlDataSource LaydulieubyID(string GiaTriParaMetter, string TenThuTuc, string TenParametter)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi ;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = TenThuTuc;
            sqldata.SelectParameters.Add(TenParametter, GiaTriParaMetter);
            return sqldata;
        }
    }
}