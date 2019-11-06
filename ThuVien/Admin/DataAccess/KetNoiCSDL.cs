using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public class KetNoiCSDL
    {
        static string ChuoiKetNoi = System.Configuration.ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString.ToString();
        SqlConnection KetNoi = new SqlConnection(ChuoiKetNoi);
        //Hàm Get,set Chuỗi Kết Nối
        public string GetSetChuoiKetNoi
        {
            get { return ChuoiKetNoi; }
            set { ChuoiKetNoi = value; }
        }

        //Hàm Get,set  Kết Nối
        public SqlConnection LayKetNoi
        {
            get { return KetNoi; }
            set { KetNoi = value; }
        }

        //Hàm Mở Kết Nối
        public void MoKetNoi()
        {
            if (KetNoi.State == ConnectionState.Closed)
            {
                KetNoi.Open();
            }
        }
        //Hàm Đóng Kết Nối
        public void DongKetNoi()
        {
            if (KetNoi.State == ConnectionState.Open)
            {
                KetNoi.Close();
            }
        }

        //Hàm thực thi một câu lệnh sql sau đó trả về DataSet
        public DataSet ThucThiLenhTraVeDataSet(string sql)
        {
            MoKetNoi();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, KetNoi);
            DataSet ds = new DataSet();
            try
            {
                adapt.Fill(ds);
            }
            catch { }
            finally
            {
                DongKetNoi();
            }
            return ds;
        }

        //Hàm thực thi một câu lệnh sql sau đó trả về bảng
        public DataTable ThucThiLenhTraVeBang(string sql)
        {
            MoKetNoi();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, KetNoi);
            DataTable dt = new DataTable();
            try
            {
                adapt.Fill(dt);
            }
            catch { }
            finally
            {
                DongKetNoi();
            }
            return dt;
        }

        //Hàm Lấy dữ liệu với tham số là một thủ  tục
        public SqlDataSource Laydulieu(string TenThuTuc)
        {
            SqlDataSource sqldata = new SqlDataSource();
            sqldata.ConnectionString = ChuoiKetNoi;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = TenThuTuc;
            return sqldata;
        }

        //Hàm Tìm Kiếm với chuỗi tìm kiếm và tên thủ tục
        public SqlDataSource Laydulieu(string GiaTriParaMetter, string TenThuTuc, string TenParametter)
        {
            SqlDataSource sqldata = new SqlDataSource();
            sqldata.ConnectionString = ChuoiKetNoi;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = TenThuTuc;
            sqldata.SelectParameters.Add(TenParametter, GiaTriParaMetter);
            return sqldata;
        }

        //Hàm Xóa Với câu lệnh Sql
        public bool Xoa(string sql)
        {
            MoKetNoi();
            SqlCommand TruyVan = new SqlCommand(sql, KetNoi);
            int SoBanGhi = TruyVan.ExecuteNonQuery();
            DongKetNoi();
            return SoBanGhi >= 1;
        }

        //Hàm xóa Nhiều Lớp với một danh sách tham số truyền vào
        public bool Xoa(List<string> DanhSach, string TenBang, string Khoa)
        {
            if (DanhSach.Count > 0)
            {
                string GiaTriCanXoa = "";
                for (int i = 0; i < DanhSach.Count; i++)
                {
                    if (i == DanhSach.Count - 1)
                        GiaTriCanXoa = GiaTriCanXoa + DanhSach[i];
                    else
                        GiaTriCanXoa = GiaTriCanXoa + DanhSach[i] + ",";
                }
                MoKetNoi();
                string Lenh = @"DELETE FROM " + TenBang + " WHERE " + Khoa + " IN (" + GiaTriCanXoa + ")";
                //Response.Write("<script> alert('"+Lenh+"'); </script>");
                SqlCommand TruyVan = new SqlCommand(Lenh, KetNoi);
                int SoBanGhi = TruyVan.ExecuteNonQuery();
                DongKetNoi();
                return SoBanGhi >= 1;
            }
            return false;
        }
    }
}