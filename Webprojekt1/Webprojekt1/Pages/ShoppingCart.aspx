<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Webprojekt1.Pages.ShoppingCart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/ShoppingCartStyle.css" rel="stylesheet" type="text/css" />

    <div class="product group">
        <div class="col-1-2 product-image">
            <div class="bg"></div>
            <div class="indicator">
                <div class="dot one"></div>
                <div class="dot two"></div>
                <div class="dot three"></div>
            </div>
        </div>
        <div class="col-1-2 product-info">
            <h1>T-shirt
                <br />
                Tommy Hilfiger
            </h1>
            <h3>$40</h3>
            <div class="select-dropdown">
                <select>
                    <option value="size">Size</option>
                    <option value="size">Small</option>
                    <option value="size">Medium</option>
                    <option value="size">Large</option>
                    <option value="size">XLarge</option>
                </select>
            </div>
             <div class="select-dropdown">
                <select>
                    <option value="quantity">1</option>
                    <option value="quantity">2</option>
                    <option value="quantity">3</option>
                    <option value="quantity">4</option>
                    <option value="quantity">5</option>
                    <option value="quantity">6</option>
                    <option value="quantity">7</option>
                    <option value="quantity">8</option>
                    <option value="quantity">9</option>
                    <option value="quantity">10</option>
                </select>
            </div>
         <a href="#"class="add-btn">Add to cart</a>
            <p>
                Thomas Jacob Hilfiger founded his eponymous
                 label Tommy Hilfiger in 1985, expanding the 
                line to include clothing, accessories, luggage
                 and fragrance. Known for his classic American 
                outlook and signature 'preppy with a twist' 
                aesthetic, Tommy Hilfiger's timeless red, white 
                and blue logo is seen across an edit of accessories, 
                sunglasses and underwear.
            </p>
           
            <ul>
               <li>Soft-touch jersey</li>
                <li>Crew-neck</li>
                <li>Plain design</li>
                <li>Logo detail </li>
                <li>95% Cotton, 5% Elastane</li>
                <li>Machine wash</li>
                <li>Our model wears a size Medium</li>
            </ul>
        </div>
    </div>
</asp:Content>
