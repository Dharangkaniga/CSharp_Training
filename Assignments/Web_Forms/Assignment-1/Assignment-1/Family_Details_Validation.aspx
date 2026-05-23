<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Family_Details_Validation.aspx.cs" Inherits="Assignment_1.Family_Details_Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator Form</title>
    <style>
        .container {
            width: 450px;
            margin: auto;
            background-color: lavender;
            padding: 20px;
            border-radius: 10px;
        }
        body {
            font-family: Arial;
            margin: 30px;
            background-color: white;
        }

        table {
            border-collapse: collapse;
        }

        td {
            padding: 8px;
        }

        .error {
            color: red;
        }

        .success {
            color: green;
            font-weight: bold;
        }
        .btnCheck {
            background-color: rebeccapurple;
            color: white;
            padding: 8px 18px;
            border-radius: 5px;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <h2 style="text-align:center">Family Details Validation Form</h2>

        <table>
            <tr>
                <td>Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Family Name:</td>
                <td>
                    <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Address:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>City:</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Zip Code:</td>
                <td>
                    <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Phone:</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Button ID="btnCheck" runat="server"
                        Text="Check"
                        CssClass="btnCheck"
                        OnClick="btnCheck_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
            </div>
    </form>
</body>
</html>
