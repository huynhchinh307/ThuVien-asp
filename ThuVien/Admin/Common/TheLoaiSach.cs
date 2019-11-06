using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class TheLoaiSach
    {
        private int _idtheloaisach;
        public int Idtheloaisach
        {
            get { return _idtheloaisach; }
            set { _idtheloaisach = value; }
        }
        private string _tentheloai;
        public string Tentheloai
        {
            get { return _tentheloai; }
            set { _tentheloai = value; }
        }
        public TheLoaiSach()
        {
        }
    }
}