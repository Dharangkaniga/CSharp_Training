using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodOrderManagement
{
    public partial class MenuDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            int id = Convert.ToInt32(Request.QueryString["MenuId"]);

            SqlCommand cmd = new SqlCommand(
                "select * from MenuItems where MenuId=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write(dr["ItemName"]);
                Response.Write("<br/>");
                Response.Write(dr["Category"]);
                Response.Write("<br/>");
                Response.Write(dr["Price"]);
            }

            con.Close();
        }



        SqlConnection con = new SqlConnection(
        ConfigurationManager.ConnectionStrings["FoodOrderDB"].ConnectionString);

        
    }
}