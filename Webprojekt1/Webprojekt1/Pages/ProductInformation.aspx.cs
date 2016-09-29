using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopDAL.ConnectedLayer;
using System.Configuration;
using WebShopDAL.Models;


namespace Webprojekt1.Pages
{
    public partial class ProductInformation : Page
    {
        private List<Product> productList { get; set; }
        public void AddToChartCart(Product p)
        {
            productList = new List<Product>();
            productList.Add(p);
            Session["AddToChartCart"] = productList;

        }
        public void ShowInChartCart()
        {
            foreach (var p in productList)
            {
                string productInCahartCart = $"<li>Product Reference:\t Brand:\t Quantity:\t Price/Unit:\t Total Price:\t Discount:\t</li>";
                productInCahartCart += $"<li> {p.ProductID}:\t {p.ProductBrand}:\t Quantity:\t {p.PriceUnit}\t Total Price:\t Discount:\t</li>";
            }
            //TODO: label1 = productInCahartCart
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            WbsDAL wbsDAL = new WbsDAL();
            wbsDAL.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
            //TODO: **** string category = _dropDownCategory.Text; ****Check how to get Insert CategoryName into the table at the same time it inserts into order
            string gender = _dropDownGender.Text;
            string color = _dropDownColor.Text;
            string size = _dropDownSize.Text;
            int quantity = Int32.Parse(_dropDownQuantity.Text);
            int productID = 0;//TODO: **** Depends on category***** => int productID = wbsDAL.GetProduct(category, gender, color, size);
            string userName = (string)Session["UserName"];
            int customerID = wbsDAL.GetCustomerLoggedID(userName);
            int orderID = wbsDAL.InsertOrderProductTable(productID, quantity, customerID);
            Response.Redirect("../OrderRec.aspx");
        }
    }
}