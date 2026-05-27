<%@ Page Title=""
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="OrderStatus.aspx.cs"
Inherits="FoodOrderManagement.OrderStatus" %>

<asp:Content ID="Content1"
ContentPlaceHolderID="ContentPlaceHolder1"
runat="server">

    <h2>Order Status Page</h2>

    <hr />

    
    <b>Total Visitors:</b>
    <asp:Label ID="lblVisitors"
        runat="server"
        ForeColor="Blue">
    </asp:Label>

    <br /><br />

    <b>Current Active Users:</b>
    <asp:Label ID="lblUsers"
        runat="server"
        ForeColor="Green">
    </asp:Label>

    <hr />

   
    <h3>Food Category Statistics</h3>

    <asp:GridView ID="GridView1"
        runat="server"
        AutoGenerateColumns="true"
        BorderWidth="1"
        CellPadding="5">
    </asp:GridView>

</asp:Content>