<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Webprojekt1.ShoppingCart" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/ShoppingCartStyle.css" rel="stylesheet" type="text/css" />

    <div class="product group">
        <div class="col-md-3 product-image">
            <div class="bg"></div>
            <div class="indicator">
                <div class="dot one"></div>
                <div class="dot two"></div>
                <div class="dot three"></div>
            </div>
        </div>
        <div class="col-md-3 product-info">
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
            
                </select>
            </div>
            <div class="select-dropdown">
                <select>
                    <option value="quantity">Quantity</option>
                    <option value="quantity">1</option>
                    <option value="quantity">2</option>
                    <option value="quantity">3</option>
                    <option value="quantity">4</option>
                    <option value="quantity">5</option>
                    <option value="quantity">6</option>
                    <option value="quantity">7</option>
                    <option value="quantity">8</option>
                    <option value="quantity">9</option>
                </select>
            </div>
            <div class="select-dropdown">
                <select>
                    <option value="color">Color</option>
                    <option value="color">Black</option>
                    <option value="color">Yellow</option>
                    <option value="color">Blue</option>
                </select>
            </div>
            <a href="#" class="add-btn">Add to cart</a>
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


        <div class="container1">
            <div class="cart_details">
                <div class="row">
                    <div class="col-sm-12 col-md-10 col-md-offset-1">
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>Product</th>
                                    <th>Quantity</th>
                                      <th>Size</th>
                                      <th>Color</th>
                                    <th>Price</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class="col-sm-8 col-md-6">
                                        <div class="media">
                                            <a class="thumbnail pull-left" href="#">
                                                <img class="media-object" src="../Pictures/ProductPictures/018390-0082.jpg" />
                                            </a>
                                            <div class="media-body">
                                                <h4><a href="#">T-Shirt</a></h4>
                                                <span>Status:</span><span class="text-success"><strong>In Stock</strong></span>
                                            </div>
                                        </div>

                                                
                                    </td>
                                   
                                    <td class="col-sm-1 col-md-1"><strong>$40</strong></td>
                                    <td class="col-sm-1 col-md-1"><strong>$40</strong></td>
                                    <td class="col-sm-1 col-md-1">
                                        <button type="button" class="btn btn-danger">
                                            <span class="glyphicon glyphicon-remove"></span>Remove
                                        </button>
                                        </td>
                                </tr>
                            <tr>
                               <td><h5>Subtotal</h5></td>
                                <td><h5><strong>$80</strong></h5></td>
                                </tr>
                                <tr>
                                    <td><h5>Shipping</h5></td>
                                    <td><h5><strong>Free</strong></h5></td>
                                </tr>
                                <tr>
                                    <td><h3>Total</h3></td>
                                    <td><h3><strong>$80</strong></h3></td>
                              </tr>
                                <tr>
                                  
                                    <td>
                                       <button type="button" class="btn btn-default">
                            <span class="glyphicon glyphicon-shopping-cart"></span> Continue Shopping
                        </button></td>
                        <td>
                        <button type="button" class="btn btn-success">
                            Checkout <span class="glyphicon glyphicon-play"></span>
                        </button></td>
                                     </tr>
                             </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        </div>

</asp:Content>
