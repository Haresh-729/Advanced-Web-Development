using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exp9Sessions
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                LWelcome.Text= Session["id"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void BLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
        }
    }
}