<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webprojekt1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
        <img src="Pictures/1920x800clock.jpg" alt="...">
      <div class="carousel-caption">
        ...
      </div>
    </div>
    <div class="item">
        <img src="Pictures/1920x800.jpeg"  alt="...">
      <div class="carousel-caption">
        ...
      </div>
    </div>
   <div class="item">
       <img src="Pictures/1920x800Shoos.jpeg"  alt="...">
      <div class="carousel-caption">
        ...
      </div>
  </div>
      </div>
       

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

    <div class="row">
        <div class="col-md-3">
            <h2>Fall clothing</h2>
            <a href="pages/Products.aspx" class="thumbnail home-thumb">
                <img src="Pictures/fashionl.jpg"  alt="...." />
                    </a>
            <p>
                Enter text here
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Winter clothing</h2>
            <a href="pages/Products.aspx" class="thumbnail home-thumb">
                <img src="Pictures/Wintercloth.jpeg"  alt="...." />
                    </a>
            <p>
                Enter text here
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Hats</h2>
            <a href="pages/Products.aspx" class="thumbnail home-thumb">
                <img src="Pictures/WinterHats.jpeg" alt="...." />
                    </a>
            <p>
                Enter text here
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Hats</h2>
            <a href="pages/Products.aspx" class="thumbnail home-thumb">
                <img src="Pictures/Shoes.jpg" alt="...." />
                    </a>
            <p>
                Enter text here
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
