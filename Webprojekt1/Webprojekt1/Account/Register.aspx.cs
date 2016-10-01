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
        /// <summary>
        /// Transaction that inserts a new customer. Needs two operations. 
        /// One:
        /// Insert value into tblZipCode and return the recent created ZipCodeID. 
        /// Second: 
        /// Insert values into tblCustomer
        /// </summary>
        protected void TransInsertCustZipCode()
        {
            try
            {
                //////////////////////////////////////////////////////////////////////////////////////////////////
                // 1 Preparing Connection                                                                       //
                //////////////////////////////////////////////////////////////////////////////////////////////////

                //Starting connection
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
                con.Open();
                //Checking if the UserName and email entered are the same, or basically checking if username is an email
                if (_txtBoxUserName.Text == _txtBoxEmail.Text)
                {
                    //If it is, take email as username
                    _txtBoxUserName = _txtBoxEmail;
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////
                // 2 Preparing declaring ZipCodeID to be able to catch it later for the qurery towards tblCustomer//
                ////////////////////////////////////////////////////////////////////////////////////////////////////
                int zipCodeID = 0;
                int zipCode = Int32.Parse(_txtBoxZipCode.Text);


                
                
                
               
                //////////////////////////////////////////////////////////////////////////////////////////////////
                // Preparing transaction that will run both insert commands towards tblZipCode and tblCustomer  //
                //////////////////////////////////////////////////////////////////////////////////////////////////

                //Transaction to ensure that customer and Zipcode are both inserted or descarted
                SqlTransaction tranx = null;
                try
                {
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    // 3 Preparing SQL string and command for tblZipCode (inserting zipcode)                        //
                    //////////////////////////////////////////////////////////////////////////////////////////////////

                    //Query to Insert ZipCode
                    string sqlInsertZipCode = @"INSERT INTO tblZipCode (ZipCode) VALUES (" + zipCode + ")";
                    
                    //Prepare Commands before executing
                    SqlCommand _sqlCmdInsertZip = new SqlCommand(sqlInsertZipCode, con);
                    //Begin transaction 
                    tranx = con.BeginTransaction();
                    _sqlCmdInsertZip.Transaction = tranx;
                    _sqlCmdInsertZip.ExecuteNonQuery();

                    ////////////////////////////////////////////////////////////////////////////////////////////////////

                    //Query to Insert into tblCustomer all entered data
                    string sqlInsertCustomer = @"INSERT INTO tblCustomer (FirstName,LastName, Address, Email, UserName, Password, ZipCodeID, RabattID)
                                    VALUES (" + _txtBoxFName.Text + ", " + _txtBoxLName.Text + ", " + _txtBoxAddress.Text + ", " + _txtBoxEmail.Text +
                                    "," + _txtBoxUserName.Text + "," + _txtBoxPassword.Text + ", " + zipCodeID + ", " + 1 + ")";
                    //Prepare Commands for inserting into Custumers table before executing
                    SqlCommand _sqlCmdInsertCust = new SqlCommand(sqlInsertCustomer, con);
                    _sqlCmdInsertCust.Transaction = tranx;
                   
                   

                    //Execute Custumer insertion                        
                    _sqlCmdInsertCust.ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////////////////////////////

                }
                catch (SqlException ex)
                {
                    Response.Write(ex.Message);
                    tranx.Rollback();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            //Calling above Transaction Method
            TransInsertCustZipCode();

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

        }
    }
}