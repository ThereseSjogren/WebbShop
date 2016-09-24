<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInformation.aspx.cs" Inherits="Webprojekt1.Pages.ProductInformation" %>

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

    <asp:DropDownList ID="DropDownListSize" AppendDataBoundItems="true" AutoPostBack="true"
DataTextField="Color" DataValueField="Color" runat ="server" >
        <asp:ListItem Value="Black" Text="Black" ></asp:ListItem>
        <asp:ListItem Value="Yellow" Text="Yellow"></asp:ListItem>
        <asp:ListItem Value="Blue" Text="Blue"></asp:ListItem>
        </asp:DropDownList>
             <%--<div class="select-dropdown">
                <select>
                    <option value="color">Black</option>
                    <option value="color">Yellow</option>
                    <option value="color">Blue</option>
                    
                </select>
            </div>--%>
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
