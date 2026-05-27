<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuList.aspx.cs" Inherits="FoodOrderManagement.MenuList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu List</title>

    <style>
        body {
            margin: 0;
            font-family: Arial;
            background-color: lavender;
        }

        .container {
            width: 80%;
            margin: 50px auto;
            background-color: lavender;
            padding: 20px;
            border-radius: 10px;
            display: flex;
            justify-content: center;
        }

       
    </style>

</head>

<body>
    <form id="form1" runat="server">

        <div class="container">

            <div class="grid-wrapper">

                <asp:GridView ID="GridView1"
                    runat="server"
                    CssClass="grid-view"
                    AutoGenerateColumns="False"
                    DataKeyNames="MenuId"
                    OnRowDeleting="GridView1_RowDeleting">

                    <Columns>

                        <asp:BoundField DataField="MenuId" HeaderText="ID" />
                        <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                        <asp:BoundField DataField="Category" HeaderText="Category" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />

                        <asp:HyperLinkField
                            Text="View"
                            DataNavigateUrlFields="MenuId"
                            DataNavigateUrlFormatString="MenuDetails.aspx?MenuId={0}" />

                        <asp:HyperLinkField
                            Text="Edit"
                            DataNavigateUrlFields="MenuId"
                            DataNavigateUrlFormatString="AddEditMenu.aspx?MenuId={0}" />

                        <asp:CommandField ShowDeleteButton="true" />

                    </Columns>

                </asp:GridView>

            </div>

        </div>

    </form>
</body>
</html>
