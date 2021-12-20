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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQUANLYSACH.mdf");
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            conn.Open();
            String SQL = "Select * from LOAISACH";
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, conn);

            DataTable LOAISACH = new DataTable();
            ADP.Fill(LOAISACH);

            this.Repeater1.DataSource = LOAISACH;
            this.Repeater1.DataBind();

            conn.Close();
        }
    }
}