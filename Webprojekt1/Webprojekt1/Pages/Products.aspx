<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Webprojekt1.Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/Filterbox.js"></script>
    <link href="../Content/ProductStyle.css" rel="stylesheet" type="text/css" />
    <div id="wrapper">
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                    <a href="#">Men Category
                    </a>
                </li>
                <li>
                    <a href="Tshirt.aspx">T-Shirt</a>
                </li>
                <li>
                    <a href="Sweatshirt.aspx">Sweatshirt</a>
                </li>
                <li>
                    <a href="Trouses.aspx">Jeans</a>
                </li>
                <li>
                  <a href="Jackets.aspx">Jacket</a>
                </li>
            </ul>
        </div>
        <div class="container">
            <div class="row">
                <p class="lead">Products</p>
               <div>
                <asp:DropDownList ID="_dropDownSize" runat="server" Width="180px">
                        <asp:ListItem>Size</asp:ListItem>
                        <asp:ListItem Value="S">Small</asp:ListItem>
                        <asp:ListItem Value="M">Medium</asp:ListItem>
                        <asp:ListItem Value="L">Large</asp:ListItem>
                    </asp:DropDownList>
            </div>
              <div>
                <asp:DropDownList ID="_dropDownColor" runat="server" Width="180px">
                        <asp:ListItem>Color</asp:ListItem>
                        <asp:ListItem Value="Black">Black</asp:ListItem>
                        <asp:ListItem Value="Yellow">Yellow</asp:ListItem>
                        <asp:ListItem Value="Blue">Blue</asp:ListItem>
                    </asp:DropDownList>
            
                
                <asp:Button ID="CreateFilter" runat="server" Text="Button" OnClick="CreateFilter_Click" />
                <br />
                  </div>
                <div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" CellPadding="4" ForeColor="#333333" GridLines="None" >
                                     <AlternatingRowStyle BackColor="White" />
                                     <Columns>
                                         <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False"         ReadOnly="True" SortExpression="ProductID" />
                                         <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                                         <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                                     </Columns>
                                     <EditRowStyle BackColor="#2461BF" />
                                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                     <RowStyle BackColor="#EFF3FB" />
                                     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                     <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                     <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                     <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    
              </div>
        </div>
        <div class="row1">
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                            <br />
                        Material: 70% Ull, 
                                 
                        
                                 <br />
                        20% Polyester, 4% Nylon,
                                    <br />
                        3% Viskos Dubbelknäppt 
                         <br />
                        Snörfodrad kant Avtagbart
                                 <br />
                        foder Tål ej maskin- eller 
                                      <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                  <br />
                        Material: 70% Ull, 
                             <br />
                        20% Polyester, 4% Nylon,
                                    <br />
                        3% Viskos Dubbelknäppt 
                              <br />
                        Snörfodrad kant Avtagbart
                                 <br />
                        foder Tål ej maskin- eller 
                                       <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                   <br />
                        Material: 70% Ull, 
                              <br />
                        20% Polyester, 4% Nylon,
                                <br />
                        3% Viskos Dubbelknäppt 
                              <br />
                        Snörfodrad kant Avtagbart
                                <br />
                        foder Tål ej maskin- eller 
                                       <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                  <br />
                        Material: 70% Ull, 
                               <br />
                        20% Polyester, 4% Nylon,
                                 <br />
                        3% Viskos Dubbelknäppt 
                                   <br />
                        Snörfodrad kant Avtagbart
                                 <br />
                        foder Tål ej maskin- eller 
                                   <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                <br />
                        Material: 70% Ull, 
                                   <br />
                        20% Polyester, 4% Nylon,
                              <br />
                        3% Viskos Dubbelknäppt 
                              <br />
                        Snörfodrad kant Avtagbart
                                  <br />
                        foder Tål ej maskin- eller 
                                   <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                  <br />
                        Material: 70% Ull, 
                                    <br />
                        20% Polyester, 4% Nylon,
                           <br />
                        3% Viskos Dubbelknäppt 
                                 <br />
                        Snörfodrad kant Avtagbart
                               <br />
                        foder Tål ej maskin- eller 
                                 <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                             <br />
                        Material: 70% Ull, 
                               <br />
                        20% Polyester, 4% Nylon,
                                     <br />
                        3% Viskos Dubbelknäppt 
                           <br />
                        Snörfodrad kant Avtagbart
                                   <br />
                        foder Tål ej maskin- eller 
                                  <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                   <br />
                        Material: 70% Ull, 
                            <br />
                        20% Polyester, 4% Nylon,
                                    <br />
                        3% Viskos Dubbelknäppt 
                                  <br />
                        Snörfodrad kant Avtagbart
                           <br />
                        foder Tål ej maskin- eller 
                                  <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                              <br />
                        Material: 70% Ull, 
                                     <br />
                        20% Polyester, 4% Nylon,
                            <br />
                        3% Viskos Dubbelknäppt 
                                <br />
                        Snörfodrad kant Avtagbart
                                  <br />
                        foder Tål ej maskin- eller 
                                   <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                                  <br />
                        Material: 70% Ull, 
                             <br />
                        20% Polyester, 4% Nylon,
                                    <br />
                        3% Viskos Dubbelknäppt 
                                <br />
                        Snörfodrad kant Avtagbart
                               <br />
                        foder Tål ej maskin- eller 
                                     <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                               <br />
                        Material: 70% Ull, 
                                <br />
                        20% Polyester, 4% Nylon,
                                <br />
                        3% Viskos Dubbelknäppt 
                             <br />
                        Snörfodrad kant Avtagbart
                                       <br />
                        foder Tål ej maskin- eller 
                                   <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 box">
                <div class="cover left">
                    <h2 class="title">Tommy Hilfiger</h2>
                    <p class="intro">
                        Produktinformation
                               <br />
                        Material: 70% Ull, 
                                   <br />
                        20% Polyester, 4% Nylon,
                             <br />
                        3% Viskos Dubbelknäppt 
                                <br />
                        Snörfodrad kant Avtagbart
                                <br />
                        foder Tål ej maskin- eller 
                                    <br />
                        handtvätt.Kemtvätt
                    </p>
                    <div class="btn">
                        <a href="ShoppingCart.aspx">Info<br />
                            40 $
                        </a>
                    </div>
                </div>
            </div>
            <hr />
            <%--<div style="margin-right: 5px; margin-top: 326px">
                        
                    </div>--%>
        </div>
    </div>
    </div>
</asp:Content>


