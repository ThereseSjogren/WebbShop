<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaleTshirts.aspx.cs" Inherits="Webprojekt1.Pages.MaleClothes.MaleTshirts" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/Filterbox.js"></script>
     <link href="../../Content/ProductStyle.css" rel="stylesheet" type="text/css"/>
    <div id="wrapper">
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                   <h3>Men T-shirts</h3>
                </li>
              
            
                <li>
                   <a href="MaleSweatshirts.aspx">Sweatshirts</a>
                </li>
                <li>
                <a href="MaleJeans.aspx">Jeans</a>
                </li>
                <li>
                   <a href="MaleJackets.aspx">Jackets</a>
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
            </div> <div class="col-md-3 box">
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
           
        </div>
    </div>
</asp:Content>

