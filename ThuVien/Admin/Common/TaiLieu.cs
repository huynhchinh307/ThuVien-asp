using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien.Admin
{
    public class TaiLieu
    {
        private int _idtailieu;
        public int Idtailieu
        {
            get { return _idtailieu; }
            set { _idtailieu = value; }
        }
        private string _tentailieu;
        public string Tentailieu
        {
            get { return _tentailieu; }
            set { _tentailieu = value; }
        }
        private string _file;
        public string File
        {
            get { return _file; }
            set { _file = value; }
        }
        private string _mota;
        public string MoTa
        {
            get { return _mota; }
            set { _mota = value; }
        }
        private int _idchuyennganh;
        public int Idchuyennganh
        {
            get { return _idchuyennganh; }
            set { _idchuyennganh = value; }
        }
        private string _hinh;
        public string Hinh
        {
            get { return _hinh; }
            set { _hinh = value; }
        }
        private int _trangthai;
        public int TrangThai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public TaiLieu()
        {
        }
    }
}