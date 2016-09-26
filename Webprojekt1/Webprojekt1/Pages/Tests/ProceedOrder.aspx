<%@ Page Title="" Language="C#" MasterPageFile="../../Site.Master" AutoEventWireup="true" CodeBehind="ProceedOrder.aspx.cs" Inherits="Webprojekt1.ProceedOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:10%">
    <h1 style="font-size: x-large; font-family: Arial, Helvetica, sans-serif; font-style: normal; text-align: center; color: #000000" class="text-center"><strong>Proceed order</strong></h1>
    </div>
    <br />
    <hr />
    <br />
    <div>
        
        <table class="nav-justified">
            <tr>
                <td style="text-align: right; width: 475px"><b>Select Category:</b></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="180px">
                        <asp:ListItem>Gender</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Child</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px; height: 20px"><strong>Select type:</strong></td>
                <td style="height: 20px">
                    <asp:DropDownList ID="DropDownList4" runat="server" Width="180px">
                        <asp:ListItem>Type</asp:ListItem>
                        <asp:ListItem>T-Shirt</asp:ListItem>
                        <asp:ListItem>Jacket</asp:ListItem>
                        <asp:ListItem>Jeans</asp:ListItem>
                        <asp:ListItem>Sweatshirt</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px"><b>Select Size:</b></td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="180px">
                        <asp:ListItem>Size</asp:ListItem>
                        <asp:ListItem>XS</asp:ListItem>
                        <asp:ListItem>S</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>L</asp:ListItem>
                        <asp:ListItem>XL</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; height: 24px; width: 475px"><b>Select Color:</b></td>
                <td style="height: 24px">
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="180px">
                        <asp:ListItem>Color</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 475px">&nbsp;</td>
                <td>
                    <asp:Button ID="_btnSubmitOrder" runat="server" Font-Bold="True" OnClick="_btnSubmitOrder_Click" Text="Submit Order" Width="180px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </div>
    <br />
    <hr />
</asp:Content>
