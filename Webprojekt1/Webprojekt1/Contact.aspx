<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Webprojekt1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        WebShop<br />
        Helsingborg 28946 Sweden<br />
        <abbr title="Phone">P:</abbr>
        0766666666
    </address>

    <address>
        <strong>Designer:</strong>   <a href="Emil.L@hotmail.se">Designer@example.com</a><br />
        <strong>Marketing:</strong> <a href="Emil.F@hotmail.se">Marketing@example.com</a>
        <strong>Programmer:</strong> <a href="Andres.M@hotmail.se">Programmer@example.com</a>
        <strong>Suporter:</strong> <a href="Terese@hotmail.se">Support@example.com</a>
    </address>
</asp:Content>
