using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopDAL.ConnectedLayer;
using System.Configuration;
using WebShopDAL.Models;
using System.Data;
using System.Data.SqlClient;

namespace Webprojekt1.Pages
{
    public partial class ProductInformation : Page
    {
       
        public void AddToChartCart(DataTable dt)
        {
            string sessionInfo = $"ProductID\tBrand\tColor\tSize\tCategoryName\tPrice Unit\tQuantity\tDiscount\tPrice\tTotal With Discount\tTotal With Tax";
                      
            Session["AddToChartCart"] = dt;
            DataTable newDt = new DataTable();
            newDt = Session["AddToChartCart"] as DataTable;
            foreach (DataRow row in newDt.Rows)
            {
                
                    int productID = (int)row["ProductID"];
                    string brand = (string)row["ProductBrand"];
                    string color = (string)row["Color"];
                    string size = (string)row["Size"];
                    string categoryName = (string)row["CategoryName"];
                    decimal priceUnit = (decimal)row["PriceUnit"];
                    int quantity = (int)row["Quantity"];
                    int rabatt = (int)row["Rabatt"];
                    decimal price = (decimal)row["Total"];
                    decimal totalWithDiscount = (decimal)row["Total with Discount"];
                    decimal totalWithTax = (decimal)row["Total with Tax"]; 


                         sessionInfo += $" <li>{productID}\t{brand}\t{color}\t{size}\t{categoryName}\t{priceUnit}\t{quantity}\t{rabatt}\t{price}\t{totalWithDiscount}\t{totalWithTax}</li>"; 

            }
            _lblTestSessionList.Text = sessionInfo;
           
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void _btnAddToChart_Click(object sender, EventArgs e)
        {
            WbsDAL wbsDAL = new WbsDAL();
            wbsDAL.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);

            //Get all product attributes to be able to call the product
            string description = "Fine brand";
            string category ="T-Shirt";         
            string gender = _dropDownGender.SelectedValue.ToString();
            string color = _dropDownColor.SelectedValue.ToString();
            string size = _dropDownSize.SelectedValue.ToString();
            int quantity = Int32.Parse(_dropDownQuantity.SelectedValue);

            //Get ProductID
            int productID = wbsDAL.GetProduct(description, category, gender, color, size);
            
            //Get DataTable with all Info
            DataTable dt = new DataTable();
            if (Session["UserName"] != null)
            {
                dt = wbsDAL.GetProductInfo(productID, category, gender, color, size, quantity, 1);
                
                AddToChartCart(dt); 
            }
            else
            {
                dt = wbsDAL.GetProductInfo(productID, category, gender, color, size, quantity, 2);
                AddToChartCart(dt);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////
            //    Should insert the order in Maste.Site.cs (shoppingCart) TODO  / Needs to reLogic it   //
            //////////////////////////////////////////////////////////////////////////////////////////////

            ////Check userName to be able to get CustomerID
            //string userName = (string)Session["UserName"];
            ////Get CustomerID to be able to get OrderID
            //int customerID = wbsDAL.GetCustomerLoggedID(userName);
            ////Get OrderID and insert into tblOrderProduct
            //int orderID = wbsDAL.InsertOrderProductTable(productID, quantity, customerID);
            //Response.Redirect("../OrderRec.aspx");
        }
    }
}