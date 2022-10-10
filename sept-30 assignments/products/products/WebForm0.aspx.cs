using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace products
{
    public partial class WebForm0 : System.Web.UI.Page
    {
        string unmae = "dora";
        string pass = "dora@123";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == unmae && TextBox2.Text == pass)
            {
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                Response.Write("invalid username and password");
            }
        }
    }
}