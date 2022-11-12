using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Exp9Sessions
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BLogin_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainconn);
            SqlCommand sqlcomm = new SqlCommand("select * from [dbo].[TABLE1] where Email=@Email and Password=@Password", sqlConn);
            sqlcomm.Parameters.AddWithValue("Email",TUser.Text);
            sqlcomm.Parameters.AddWithValue("Password", TPass.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt =new DataTable();
            sda.Fill(dt);
            sqlConn.Open();
            sqlcomm.ExecuteNonQuery();
            sqlConn.Close();
            if(dt.Rows.Count > 0)
            {
                Session["id"] = TUser.Text;
                Response.Redirect("Welcome.aspx");
                Session.RemoveAll();
            }
            else
            {
                LitMsg.Text = "Username or Password is Incorrect...!";
            }

        }
    }
}