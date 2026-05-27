using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodOrderManagement
{
    public partial class OrderStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblVisitors.Text =
                Application["TotalVisitors"].ToString();

            lblUsers.Text =
                Application["CurrentUsers"].ToString();



            if (Cache["FoodCategoryStats"] == null)
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Category, COUNT(*) TotalItems FROM MenuItems GROUP BY Category",
                    con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Cache.Insert("FoodCategoryStats", dt, null,
                    DateTime.Now.AddMinutes(5),
                    System.Web.Caching.Cache.NoSlidingExpiration);
            }

            GridView1.DataSource = Cache["FoodCategoryStats"];
            GridView1.DataBind();
        }

        SqlConnection con = new SqlConnection(
       ConfigurationManager.ConnectionStrings["FoodOrderDB"].ConnectionString);       
    }

}
