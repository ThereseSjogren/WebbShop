<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Webprojekt1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
<div id="12" class="container">
<div class="row">
    <div class="col-lg-6">
      <div></div>
      <div class="form-group">
        <label for="InputName">Your Name</label>
        <div class="input-group">
          <input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      <div class="form-group">
        <label for="InputEmail">Your Email</label>
        <div class="input-group">
          <input type="email" class="form-control" id="InputEmail" name="InputEmail" placeholder="Enter Email" required  >
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      <div class="form-group">
        <label for="InputMessage">Message</label>
        <div class="input-group"
>
          <textarea name="InputMessage" id="InputMessage" class="form-control" rows="5" required></textarea>
      </div>
      
      <input type="submit" name="submit" id="submit" value="Submit" class="btn btn-info pull-right">
    </div>

  <hr class="featurette-divider hidden-lg">
  <div class="col-lg-5 col-md-push-1">
    <address >
    
    <p class="lead">
Helsingborg S 26458<<br>
      Phone: 042-00000<br>
      </p>
    </address>
  </div>
</div>
</div>
    </div>
       
</asp:Content>
