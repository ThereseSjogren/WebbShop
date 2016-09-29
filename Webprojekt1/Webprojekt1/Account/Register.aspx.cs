using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Webprojekt1.Models;
using System.Data.SqlClient;
using System.Configuration;
using WebShopDAL.ConnectedLayer;
using WebShopDAL.Models;
using System.IO;

namespace Webprojekt1.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {

            #region PreviousCode
            //var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            //var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            //IdentityResult result = manager.Create(user, Password.Text);
            //if (result.Succeeded)
            //{
            //    signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
            //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //}
            //else 
            //{
            //    ErrorMessage.Text = result.Errors.FirstOrDefault();
            //} 
            #endregion


            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
                con.Open();

                if (_txtBoxUserName.Text == _txtBoxEmail.Text)
                {
                    _txtBoxUserName = _txtBoxEmail;
                    string sql = $"INSERT INTO tblCustomer (FirstName,LastName, Address, Email, UserName, Password, ZipCodeID, RabattID) VALUES ('{_txtBoxFName.Text}','{_txtBoxLName.Text}', '{_txtBoxAddress.Text}','{_txtBoxEmail.Text}', '{_txtBoxUserName.Text}', '{_txtBoxPassword.Text}', {Int32.Parse(_txtBoxZipCode.Text)},{1})";
                    using (SqlCommand _sqlCommand = new SqlCommand(sql, con))
                    {
                        //_sqlCommand.Parameters.AddWithValue("@FirstName", _txtBoxFName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@LastName", _txtBoxLName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Address", _txtBoxAddress.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Email", _txtBoxEmail.Text);
                        //_sqlCommand.Parameters.AddWithValue("@UserName", _txtBoxUserName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Password", _txtBoxPassword.Text);
                        //_sqlCommand.Parameters.AddWithValue("@ZipCodeID", Int32.Parse(_dropDownListZipCode.SelectedValue));
                        //_sqlCommand.Parameters.AddWithValue("@RabattID", 1);

                        _sqlCommand.ExecuteNonQuery();
                        Response.Redirect("login.aspx");
                        Response.Write("Your registration was successfull!");
                    }
                }
                else
                {
                    string sql = $"INSERT INTO tblCustomer (FirstName,LastName, Address, Email, UserName, Password, ZipCodeID, RabattID) VALUES ('{_txtBoxFName.Text}','{_txtBoxLName.Text}', '{_txtBoxAddress.Text}','{_txtBoxEmail.Text}', '{_txtBoxUserName.Text}', '{_txtBoxPassword.Text}', {Int32.Parse(_txtBoxZipCode.Text)},{1})";
                    using (SqlCommand _sqlCommand = new SqlCommand(sql, con))
                    {
                        //_sqlCommand.Parameters.AddWithValue("@FirstName", _txtBoxFName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@LastName", _txtBoxLName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Address", _txtBoxAddress.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Email", _txtBoxEmail.Text);
                        //_sqlCommand.Parameters.AddWithValue("@UserName", _txtBoxUserName.Text);
                        //_sqlCommand.Parameters.AddWithValue("@Password", _txtBoxPassword.Text);
                        //_sqlCommand.Parameters.AddWithValue("@ZipCodeID", Int32.Parse(_dropDownListZipCode.SelectedValue));
                        //_sqlCommand.Parameters.AddWithValue("@RabattID", 1);

                        _sqlCommand.ExecuteNonQuery();
                        Response.Redirect("login.aspx");
                        Response.Write("Your registration was successfull!");
                    }
                }
            }

            catch (Exception ex)
            {

                Response.Write(ex.Message);



            }
        }
    }
}