using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class BaiViet
    {
        private string _idbaiviet;
        public string Idbaiviet
        {
            get { return _idbaiviet; }
            set { _idbaiviet = value; }
        }
        private string _tenbaiviet;
        public string Tenbaiviet
        {
            get { return _tenbaiviet; }
            set { _tenbaiviet = value; }
        }
        private string _noidung;
        public string Noidung
        {
            get { return _noidung; }
            set { _noidung = value; }
        }
        private DateTime _thoigian;
        public DateTime Thoigian
        {
            get { return _thoigian; }
            set { _thoigian = value; }
        }
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public BaiViet()
        {
            _nguoidung = new NguoiDung();
        }
    }
}