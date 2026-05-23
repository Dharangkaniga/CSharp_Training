<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Flowers.aspx.cs" Inherits="Assignment_1.Flowers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Selector</title>
    <style>
        body {
            font-family: Arial;
            margin: 40px;
            background-color:white;
            display: flex;
            justify-content: center;   
            align-items: center;       
            height: 100vh;  
        }
        img {
            width: 200px;
            height: 200px;
            border: 1px solid black;
            margin-top: 10px;
        }
        .container {
            background-color:lavender;
            padding: 20px;
            border-radius: 15px;
            width: 450px;
            text-align: center;
        }
        .btn {
            margin-top: 15px;
            padding: 10px 15px;
            background-color:rebeccapurple;
            color: white;
            border-radius: 8px;
            cursor: pointer;
            width: 50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container"> 
        <h2 style="text-align:center">Flower Selector</h2>  

        <asp:DropDownList ID="ddlFlowers" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="ddlFlowers_SelectedIndexChanged">
        </asp:DropDownList>

        <br /><br />     
        <asp:Image ID="imgFlower" runat="server" />

        <br /><br />   
        <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" CssClass="btn"
            OnClick="btnGetPrice_Click" />

        <br /><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price: " />
     </div>
    </form>
</body>
</html>
