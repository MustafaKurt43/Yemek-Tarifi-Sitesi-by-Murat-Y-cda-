﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace intProgProjeYemekTarifleri
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        SqlSinif bgl=new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From tbl_Yemekler",bgl.baglanti());
            SqlDataReader dr=komut.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
        }
    }
}