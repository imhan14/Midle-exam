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
    public partial class pageDANHSACHSACH : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQUANLYSACH.mdf");
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            conn.Open();
            String SQL = "Select * From SACH";
            if (Request.QueryString.Get("IDDM") != null)
                SQL += " where MALOAI= " + Request.QueryString.Get("IDDM");
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, conn);
            DataTable SACH = new DataTable();
            ADP.Fill(SACH);
            this.DataList1.DataSource = SACH;
            this.DataList1.DataBind();
            this.DataList1.RepeatColumns = 3;
            conn.Close();
        }
    }
}