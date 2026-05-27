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
    public partial class AddEditMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        SqlConnection con = new SqlConnection(
        ConfigurationManager.ConnectionStrings["FoodOrderDB"].ConnectionString);

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string query = "insert into MenuItems values(@ItemName,@Category,@FoodType,@Price,@Qty,@Available,@Date)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@FoodType", ddlFoodType.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text);
            cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("MenuList.aspx");
        }
    }
}