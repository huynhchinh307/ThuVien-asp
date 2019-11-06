using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien
{
    public class ChuyenNganh
    {
        private int _idchuyennganh;
        public int Idchuyennganh
        {
            get { return _idchuyennganh; }
            set { _idchuyennganh = value; }
        }
        private string _tenchuyennganh;
        public string Tenchuyennganh
        {
            get { return _tenchuyennganh; }
            set { _tenchuyennganh = value; }
        }
        public ChuyenNganh()
        {
        }
    }
}