using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace Assignment_1
{
    public partial class Flowers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlFlowers.Items.Clear();

                ddlFlowers.Items.Add(new ListItem("Select Flower", "0"));
                ddlFlowers.Items.Add(new ListItem("Rose", "rose"));
                ddlFlowers.Items.Add(new ListItem("Lily", "lily"));
                ddlFlowers.Items.Add(new ListItem("Tulip", "tulip"));
                ddlFlowers.Items.Add(new ListItem("Jasmine", "jasmine"));

                lblPrice.Text = "Price: ";
            }
        }

        protected void ddlFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flower = ddlFlowers.SelectedItem.Text.ToLower();

            switch (flower)
            {
                case "rose":
                    imgFlower.ImageUrl =
                        "https://img.magnific.com/free-photo/beautiful-rose-nature_23-2150737301.jpg?w=360";
                    break;

                case "lily":
                    imgFlower.ImageUrl =
                        "https://static.vecteezy.com/system/resources/thumbnails/048/240/710/small/white-lily-flowers-banner-white-lily-flower-view-shows-petals-stamens-leaves-and-buds-on-a-twig-on-a-clear-blue-sky-day-isolated-on-bright-blue-sky-photo.JPG";
                    break;

                case "tulip":
                    imgFlower.ImageUrl =
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTutfnTmlITkfN09nCvnUhvM3NC3yeX3TdfpA&s";
                    break;

                case "jasmine":
                    imgFlower.ImageUrl =
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_MJq8B82Ve6idBc7SEDmv7ZVQIuCToEDtsw&s";
                    break;

                default:
                    imgFlower.ImageUrl =
                        "https://via.placeholder.com/200?text=Select+Flower";
                    break;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string flower = ddlFlowers.SelectedValue;

            switch (flower)
            {
                case "rose":
                    lblPrice.Text = "Price: ₹50";
                    break;

                case "lily":
                    lblPrice.Text = "Price: ₹100";
                    break;

                case "tulip":
                    lblPrice.Text = "Price: ₹450";
                    break;

                case "jasmine":
                    lblPrice.Text = "Price: ₹200";
                    break;

                default:
                    lblPrice.Text = "Price: Please select a flower";
                    break;
            }
        }
    }
}
