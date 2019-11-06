using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class Sach
    {
        private int _idsach;
        public int Idsach
        {
            get { return _idsach; }
            set { _idsach = value; }
        }
        private int _idtheloaisach;
        public int Idtheloaisach
        {
            get { return _idtheloaisach; }
            set { _idtheloaisach = value; }
        }
        private int _idnhaxuatban;
        public int Idnhaxuatban
        {
            get { return _idnhaxuatban; }
            set { _idnhaxuatban = value; }
        }
        private string _tensach;
        public string TenSach
        {
            get { return _tensach; }
            set { _tensach = value; }
        }
        private string _tacgia;
        public string Tacgia
        {
            get { return _tacgia; }
            set { _tacgia = value; }
        }
        private string _hinh;
        public string Hinh
        {
            get { return _hinh; }
            set { _hinh = value; }
        }
        private string _file;
        public string File
        {
            get { return _file; }
            set { _file = value; }
        }
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public int _trangthai;
        private int TrangThai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
        private string _mota;
        public string MoTa
        {
            get { return _mota; }
            set { _mota = value; }
        }
        public Sach()
        {
        }
    }
}