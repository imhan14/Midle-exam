using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace IS385_NGUYENQUANGHAN_1605_QUANLYSACH
{
    public partial class pageCHITIETSACH : System.Web.UI.Page
    {
        SqlConnection conn;
        DataTable SACH;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQUANLYSACH.mdf");
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            conn.Open();

            string SQL = null;
            if (Request.QueryString.Get("IDS") != null)
                SQL = "Select * From SACH WHERE MASACH=" + Request.QueryString.Get("IDS");
            Response.Write(SQL);
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, conn);

            SACH = new DataTable();
            ADP.Fill(SACH);

            this.Repeater2.DataSource = SACH;
            this.Repeater2.DataBind();
            conn.Close();
        }
    }
}