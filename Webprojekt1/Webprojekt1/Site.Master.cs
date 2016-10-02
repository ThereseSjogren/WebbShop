using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using WebShopDAL.Models;
using WebShopDAL.ConnectedLayer;

namespace Webprojekt1
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;
        private List<ProductOrderInfoChartCart> listChart;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //listChart = (List<ProductOrderInfoChartCart>)Session["AddToChartCart"];
            //_listViewChart.DataSource = listChart;
            //_listViewChart.DataBind();
            //if (Session["AddToChartCart"] == null)
            //{
                listChart = (List<ProductOrderInfoChartCart>)Session["AddToChartCart"];
                _listViewChart.DataSource = listChart;
                _listViewChart.DataBind();

                #region LargeVersionCode
                //string sessionInfo = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tQuantity\tDiscount\tPrice\tTotal With Discount\tTotal With Tax";

                //DataTable newDt = (DataTable)Session["AddToChartCart"];

                //foreach (DataRow row in newDt.Rows)
                //{

                //    int productID = (int)row["ProductID"];
                //    string brand = (string)row["ProductBrand"];
                //    string color = (string)row["Color"];
                //    string size = (string)row["Size"];
                //    string categoryName = (string)row["CategoryName"];
                //    decimal priceUnit = (decimal)row["PriceUnit"];
                //    int quantity = (int)row["Quantity"];
                //    int rabatt = (int)row["Rabatt"];
                //    decimal price = (decimal)row["Total"];
                //    decimal totalWithDiscount = (decimal)row["Total with Discount"];
                //    decimal totalWithTax = (decimal)row["Total with Tax"];


                //    sessionInfo += $" <li>{productID}\t{brand}\t{color}\t{size}\t{categoryName}\t{priceUnit}\t{quantity}\t{rabatt}\t{price}\t{totalWithDiscount}\t{totalWithTax}</li>"; 
                //}
                //_lblShowCart.Text = sessionInfo; 
                #endregion
            //}


            #region FirstCode
            //---------------------------------------------------------------------------
            //if (Session["AddToChartCart"] != null)
            //{
            //    string infoChart = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tRabattID\tQuantity\tPrice\tTotal With Discount\tTotal With Tax";
            //    List<ProductOrderInfoChartCart> myChartList = new List<ProductOrderInfoChartCart>();
            //    myChartList = (List<ProductOrderInfoChartCart>)Session["AddToChartCart"];
            //    foreach (var p in myChartList)
            //    {
            //        infoChart += $"<li>{p.ProductID}\t{p.Brand}\t{p.Color}\t{p.Size}t{p.CategoryName}\t{p.PriceUnit}\t{p.RabattID}\t{p.Quantity}\t{p.Price}\t{p.TotalWithDiscount}\t{p.TotalWithTax}</li>";
            //        _lblShowCart.Text = infoChart;
            //    }
            //}

            #endregion
        }
        protected void ConfirmOrderShoppingCart_Click(object sender, EventArgs e)
        {
            if ((string)Session["UserName"] != null)
            {
                WbsDAL wbsDAL = new WbsDAL();
                wbsDAL.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
                foreach (var p in listChart)
                {
                    //Decreasing in DB the 
                    p.Quantity = -p.Quantity;
                    string userName = (string)Session["UserName"];
                    int customerID = wbsDAL.GetCustomerLoggedID(userName);
                    int orderID = wbsDAL.InsertOrderProductTable(p.ProductID, p.Quantity, customerID);
                    Response.Redirect("/Pages/OrderRec.aspx");
                }
            }
            else
                Response.Redirect("/Pages/AnonymousUserDetails");

        }
        protected void OpenShoppingCart_Click(object sender, EventArgs e)
        {
            
            #region FirstCode
            //string sessionInfo = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tQuantity\tDiscount\tPrice\tTotal With Discount\tTotal With Tax";

            //DataTable newDt = Session["AddToChartCart"] as DataTable;

            //foreach (DataRow row in newDt.Rows)
            //{

            //    int productID = (int)row["ProductID"];
            //    string brand = (string)row["ProductBrand"];
            //    string color = (string)row["Color"];
            //    string size = (string)row["Size"];
            //    string categoryName = (string)row["CategoryName"];
            //    decimal priceUnit = (decimal)row["PriceUnit"];
            //    int quantity = (int)row["Quantity"];
            //    int rabatt = (int)row["Rabatt"];
            //    decimal price = (decimal)row["Total"];
            //    decimal totalWithDiscount = (decimal)row["Total with Discount"];
            //    decimal totalWithTax = (decimal)row["Total with Tax"];


            //    sessionInfo += $" <li>{productID}\t{brand}\t{color}\t{size}\t{categoryName}\t{priceUnit}\t{quantity}\t{rabatt}\t{price}\t{totalWithDiscount}\t{totalWithTax}</li>";

            //}
            //_lblShowCart.Text = sessionInfo;
            //------------------------------------------------------------------------------------------------------
            //if (Session["AddToChartCart"] != null)
            //{
            //    string infoChart = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tRabattID\tQuantity\tPrice\tTotal With Discount\tTotal With Tax";
            //    List<ProductOrderInfoChartCart> myChartList = new List<ProductOrderInfoChartCart>();
            //    myChartList = (List<ProductOrderInfoChartCart>)Session["AddToChartCart"];
            //    foreach (var p in myChartList)
            //    {
            //        infoChart += $"<li>{p.ProductID}\t{p.Brand}\t{p.Color}\t{p.Size}t{p.CategoryName}\t{p.PriceUnit}\t{p.RabattID}\t{p.Quantity}\t{p.Price}\t{p.TotalWithDiscount}\t{p.TotalWithTax}</li>";
            //        _lblShowCart.Text = infoChart;
            //    }
            //}
            //else
            //{
            //    string infoChart = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tRabattID\tQuantity\tPrice\tTotal With Discount\tTotal With Tax";
            //    List<ProductOrderInfoChartCart> myChartList = new List<ProductOrderInfoChartCart>();
            //    myChartList = (List<ProductOrderInfoChartCart>)Session["AddToChartCart"];
            //    foreach (var p in myChartList)
            //    {
            //        infoChart += $"<li>{p.ProductID}\t{p.Brand}\t{p.Color}\t{p.Size}t{p.CategoryName}\t{p.PriceUnit}\t{p.RabattID}\t{p.Quantity}\t{p.Price}\t{p.TotalWithDiscount}\t{p.TotalWithTax}</li>";
            //        _lblShowCart.Text = infoChart;
            //    }
            //} 
            #endregion
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }

}

