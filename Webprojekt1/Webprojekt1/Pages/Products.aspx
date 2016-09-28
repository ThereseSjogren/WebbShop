<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Webprojekt1.Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/Filterbox.js"></script>
    <link href="../Content/ProductStyle.css" rel="stylesheet" type="text/css" />
    <div id="wrapper">
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                    <a href="#">Category
                    </a>
                </li>
                <li>
                    <a href="Tshirt.aspx">T-Shirt</a>
                </li>
                <li>
                    <a href="Sweatshirt.aspx">Sweatshirt</a>
                </li>
                <li>
                    <a href="Trouses.aspx">Trouses</a>
                </li>
                <li>
                    <a href="Jackets.aspx">Jacket</a>
                </li>
            </ul>
        </div>
        <div class="container">
            <div class="row">
                <p class="lead">Products</p>
                <div class="btn-group show-on-hover">
                    <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                        Size <span class="caret"></span>
                    </button>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="#">Small</a></li>
                        <li><a href="#">Medium</a></li>
                        <li><a href="#">Large</a></li>
                        <li><a href="#">XLarge</a></li>
                    </ul>
                </div>
                <div class="btn-group show-on-hover">
                    <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                        Color <span class="caret"></span>
                    </button>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="#">Black</a></li>
                        <li><a href="#">White</a></li>
                        <li><a href="#">Yellow</a></li>
                    </ul>
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
</asp:Content>


