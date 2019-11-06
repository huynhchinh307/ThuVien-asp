﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuVien
{
    public partial class Sach1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataSach.DataSource = dao.Laydulieu("Sach_Select");
            dataSach.DataBind();
        }
    }
}