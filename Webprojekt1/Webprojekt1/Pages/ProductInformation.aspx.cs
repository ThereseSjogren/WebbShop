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
        private List<ProductOrderInfoChartCart> chartCartList { get; set; }
        public void AddToChartCart(DataTable dt)
        {
            foreach (var row in dt.Rows)
            {
                int productID = (int)row;
                string brand = (string)row;
                string color = (string)row;
                string size = (string)row;
                string categoryName = (string)row;
                decimal priceUnit = (decimal)row;                
                int rabattID = (int)row;
                int quantity = (int)row;
                decimal price = (decimal)row;
                decimal totalWithDiscount = (decimal)row;
                decimal totalWithTax = (decimal)row;
                var productOrderInfo = new ProductOrderInfoChartCart(productID, brand, color, size, categoryName, priceUnit, rabattID, quantity, price, totalWithDiscount, totalWithTax);
                chartCartList = new List<ProductOrderInfoChartCart>();
                chartCartList.Add(productOrderInfo);
                Session["AddToChartCart"] = chartCartList;
            }
            
                
                
               
                
            

        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void _btnAddToChart_Click(object sender, EventArgs e)
        {
            WbsDAL wbsDAL = new WbsDAL();
            wbsDAL.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);

            //Get all product attributes to be able to call the product
            string category = null; /* = _dropDownCategory.Text;         WARNING: NEED variable category from form!!!!!*/
            string gender = _dropDownGender.Text;
            string color = _dropDownColor.Text;
            string size = _dropDownSize.Text;
            int quantity = Int32.Parse(_dropDownQuantity.Text);

            //Get ProductID
            int productID = wbsDAL.GetProduct(category, gender, color, size);

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

            
            //Check userName to be able to get CustomerID
            string userName = (string)Session["UserName"];
            //Get CustomerID to be able to get OrderID
            int customerID = wbsDAL.GetCustomerLoggedID(userName);
            //Get OrderID
            int orderID = wbsDAL.InsertOrderProductTable(productID, quantity, customerID);
            Response.Redirect("../OrderRec.aspx");
        }
    }
}