<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmOrder.aspx.cs" Inherits="Webprojekt1.Pages.ConfirmOrder" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/ConFirmOrderStyle.css" rel="stylesheet" type="text/css"/>



    <div class="container">
        <div class="block">
            <div class="span12">

                <div class="wrapper-no-padding shopping-cart">
                    <table class="cart-table">

                        <tr class="heading heading-font">
                            <th class="cart-item pl">Cart Items</th>
                            <th class="cart-item-price">Price</th>
                            <th class="cart-item-quantity">Quantity</th>
                            <th class="cart-item-total pr">Color</th>
                            <th class="cart-item-total pr">size</th>
                            <th class="cart-item-total pr">Total</th>
                        </tr>
                        <tr class="item-row">

                            <td class="cart-item">
                                <table>
                                    <tr>
                                        <td>
                                            <img src="#" alt="" /></td>
                                        <td>
                                            <p class="item-name">T-shirt</p>
                                            <p><a href="#">Remove Item</a></p>
                                        </td>
                                    </tr>
                                </table>
                            </td>

                            <td class="cart-item-price">
                                <p>$15.00</p>
                            </td>

                            <td class="cart-item-quantity">
                                <input type="number" class="span1" value="1" />
                            </td>

                            <td class="cart-item-color">
                                <p>black</p>
                            </td>

                            <td class="cart-item-size">
                                <p>Large</p>
                            </td>

                            <td class="cart-item-total slab-font pr">
                                <p>$15.00</p>
                            </td>

                        </tr>

                    </table>
                </div>

            </div>
            <div class="span6 hidden-phone">

                <div class="wrapper-no-padding">
                    <table class="cart-table">
                        <caption class="slab-font">Customer</caption>
                    </table>
                    <div class="block">
                        <div class="span4">
                            <div class="cart-wrapper no-pr">
                                <input type="text" class="input-block-level" placeholder="Firstname" required />
                            </div>
                        </div>

                         <div class="span4">
                            <div class="cart-wrapper no-pr">
                                <input type="text" class="input-block-level" placeholder="Lastname" required />
                            </div>
                        </div>

                         <div class="span4">
                            <div class="cart-wrapper no-pr">
                                <input type="text" class="input-block-level" placeholder="Zip Code" required/>
                            </div>
                        </div>

                         <div class="span4">
                            <div class="cart-wrapper no-pr">
                                <input type="text" class="input-block-level" placeholder="Email" required />
                            </div>
                        </div>

                        <div class="span2">
                            <div class="cart-wrapper no-pl">
                                <button class="btn btn-block" type="button">Send</button>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>


</asp:Content>
