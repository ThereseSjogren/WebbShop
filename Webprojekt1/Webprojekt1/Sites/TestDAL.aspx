<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDAL.aspx.cs" Inherits="Webprojekt1.Sites.TestDAL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3 style="text-align:center"><strong>All Inventory (Products)</strong></h3>
        <asp:GridView ID="_productGridView" runat="server" style="margin-left: 191px; margin-top: 82px" Width="60%" AutoGenerateColumns="False" ItemType="WebShopDAL.Models.Product" DataKeyFrames="ProductID" SelectMethod="GetAllProducts">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="PriceUnit" HeaderText="PriceUnit" SortExpression="PriceUnit" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
            </Columns>
        </asp:GridView>
    </div>
        
    </form>
</body>
</html>
