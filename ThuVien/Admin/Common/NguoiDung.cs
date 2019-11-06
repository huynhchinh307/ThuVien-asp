using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class NguoiDung
    {
        private string _idnguoidung;
        public string Idnguoidung
        {
            get { return _idnguoidung; }
            set { _idnguoidung = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private string _tennguoidung;
        public string Tennguoidung
        {
            get { return _tennguoidung; }
            set { _tennguoidung = value; }
        }
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _matkhau;
        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}