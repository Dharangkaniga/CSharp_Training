using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodOrderManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "food@123")
            {
                Session["Username"] = txtUser.Text;
                Session["Role"] = "Admin";
                lblMsg.Text = "Login Successfull !!!.";
                Response.Redirect("MenuList.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid Login. You are not Authorized User !!!.";
            }
        }

    }
}