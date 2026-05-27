<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEditMenu.aspx.cs" Inherits="FoodOrderManagement.AddEditMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Item Name:
<asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator
ID="rfv1"
runat="server"
ControlToValidate="txtItemName"
ErrorMessage="Enter item name"
ForeColor="Red" />

<br />

Category:
<asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>

<br />

Food Type:
<asp:DropDownList ID="ddlFoodType" runat="server">
    <asp:ListItem>Veg</asp:ListItem>
    <asp:ListItem>Non-Veg</asp:ListItem>
</asp:DropDownList>

<br />

Price:
<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>

<asp:RangeValidator
ID="rv1"
runat="server"
ControlToValidate="txtPrice"
MinimumValue="1"
MaximumValue="1000"
Type="Double"
ErrorMessage="Price must be between 1 and 1000"
ForeColor="Red" />

<br />

Quantity:
<asp:TextBox ID="txtQty" runat="server"></asp:TextBox>

<asp:CompareValidator
ID="cv1"
runat="server"
ControlToValidate="txtQty"
Operator="DataTypeCheck"
Type="Integer"
ErrorMessage="Enter valid quantity"
ForeColor="Red" />

<br />

Category Format:
<asp:TextBox ID="txtCatFormat" runat="server"></asp:TextBox>

<asp:RegularExpressionValidator
ID="rev1"
runat="server"
ControlToValidate="txtCatFormat"
ValidationExpression="^[A-Za-z ]+$"
ErrorMessage="Only letters allowed"
ForeColor="Red" />

<br />

Available:
<asp:CheckBox ID="chkAvailable" runat="server" />

<br />

<asp:Button ID="btnSave" runat="server"
    Text="Save"
    OnClick="btnSave_Click" />

<br />

<asp:ValidationSummary
ID="vs1"
runat="server"
ForeColor="Red" />
        </div>
    </form>
</body>
</html>
