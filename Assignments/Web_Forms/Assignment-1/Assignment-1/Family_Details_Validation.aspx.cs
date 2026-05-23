using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Family_Details_Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(txtFamilyName.Text.Trim(),
                StringComparison.OrdinalIgnoreCase))
            {
                ShowError("Name must be different from Family Name.");
                return;
            }

            if (txtAddress.Text.Trim().Length < 2)
            {
                ShowError("Address must contain at least 2 letters.");
                return;
            }

            if (txtCity.Text.Trim().Length < 2)
            {
                ShowError("City must contain at least 2 letters.");
                return;
            }

            if (!Regex.IsMatch(txtZip.Text.Trim(), @"^\d{5}$"))
            {
                ShowError("Zip Code must contain exactly 5 digits.");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{2,3}-\d{7}$"))
            {
                ShowError("Phone must be in format XX-XXXXXXX or XXX-XXXXXXX.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ShowError("Invalid email address.");
                return;
            }

            lblResult.CssClass = "success";
            lblResult.Text = "All validations passed successfully!!!";
        }

        private void ShowError(string message)
        {
            lblResult.CssClass = "error";
            lblResult.Text = message;
        }
    }
}