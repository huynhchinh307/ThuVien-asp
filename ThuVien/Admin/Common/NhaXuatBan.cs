using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class NhaXuatBan
    {
        private int _idnhaxuatban;
        public int Idnhaxuatban
        {
            get { return _idnhaxuatban; }
            set { _idnhaxuatban = value; }
        }
        private string _tennhaxuatban;
        public string Tennhaxuatban
        {
            get { return _tennhaxuatban; }
            set { _tennhaxuatban = value; }
        }
        public NhaXuatBan()
        {
        }
    }
}