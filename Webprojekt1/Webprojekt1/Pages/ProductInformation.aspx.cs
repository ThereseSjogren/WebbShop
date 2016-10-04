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
using System.Text;

namespace Webprojekt1.Pages
{
    public partial class ProductInformation : Page
    {
        protected List<ProductOrderInfoChartCart> listChart;

        public void AddToChartCart(Product p)
        {
            //Add list to Session

            
            List<Product> _productList = new List<Product>();
            _productList = (List<Product>)Session["AddToChartCart"];
            _productList.Add(p);
            Session["AddToChartCart"] = _productList;

            #region FirstCode

            //newDt = Session["AddToChartCart"] as DataTable;
            //foreach (DataRow row in newDt.Rows)
            //{

            //        int productID = (int)row["ProductID"];
            //        string brand = (string)row["ProductBrand"];
            //        string color = (string)row["Color"];
            //        string size = (string)row["Size"];
            //        string categoryName = (string)row["CategoryName"];
            //        decimal priceUnit = (decimal)row["PriceUnit"];
            //        int quantity = (int)row["Quantity"];
            //        int rabatt = (int)row["Rabatt"];
            //        decimal price = (decimal)row["Total"];
            //        decimal totalWithDiscount = (decimal)row["Total with Discount"];
            //        decimal totalWithTax = (decimal)row["Total with Tax"]; 


            //             sessionInfo += $" <li>{productID}\t{brand}\t{color}\t{size}\t{categoryName}\t{priceUnit}\t{quantity}\t{rabatt}\t{price}\t{totalWithDiscount}\t{totalWithTax}</li>"; 

            //}
            //_lblTestSessionList.Text = sessionInfo; 
            #endregion

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ////////////////////////
            //  LOAD Product //
            ////////////////////////

            int number;
            //string markupHTML = "";
            Product p = new Product();
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);

            number = Decimal.ToInt32(p.PriceUnit);
            StringBuilder markupHTML = new StringBuilder("");
            markupHTML.Append("<div class=\"product group\">");
                markupHTML.Append("<div class =\"thumbnail\" >");
                    markupHTML.Append("<img src =\"/Images/" + p.ImageURL + "\" alt=\"Generic placeholder thumbnail\">");
                markupHTML.Append("</div>");
                markupHTML.Append("<div class = \"caption\">");
                    markupHTML.Append("<h3></h3>");
                    markupHTML.Append("<span>"+ p.Size +"</span");
                    markupHTML.Append("<h2 class=\"title\">" + p.ProductBrand  + "</h2>");
                markupHTML.Append("</div>");
                markupHTML.Append("<div class=\"col-1-2 product-info\">");
                    markupHTML.Append("<h1>" + p.ProductBrand + "</h1>");
                    markupHTML.Append("<br />");
                    markupHTML.Append("" + p.ProductDescription + "");
                    markupHTML.Append("<br />");
                    markupHTML.Append("<h3>" + number + "SEK</h3>");
                    markupHTML.Append("<asp:DropDownList ID=\"_dropDownQuantity\" runat=\"server\" Width=\"180px\">");
                    markupHTML.Append("<asp:ListItem>Quantity</asp:ListItem>");
                    markupHTML.Append("<asp:ListItem>1</asp:ListItem>");
                    markupHTML.Append("<asp:ListItem>2</asp:ListItem>");
                    markupHTML.Append("<asp:ListItem>3</asp:ListItem>");
                    markupHTML.Append("<asp:ListItem>4</asp:ListItem>");
                    markupHTML.Append("<asp:ListItem>5</asp:ListItem>");
                    markupHTML.Append("</asp:DropDownList>");
                    markupHTML.Append("<br />");
                markupHTML.Append("<div class=\"add-btn\"  Text=\"Add to cart\"  OnClick=\"_btnAddToChart_Click\" runat=\"server\">");
                markupHTML.Append("</div>");
            markupHTML.Append("</div>");


            InsertedProduct.InnerHtml = markupHTML.ToString();

           
            

        }

        //protected void _btnAddToChart_Click()
        //{
        //    int quantity = Int32.Parse(_dropDownQuantity.SelectedValue);
        //    WbsDAL wbsDAL = new WbsDAL();
        //    wbsDAL.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
        //    Product p = new Product();
        //    p = wbsDAL.GetProductForProdIformation();


            //    //Get all product attributes to be able to call the product
            //    //string description = "Fine brand";
            //    //string category = "T-Shirt";
            //    //string gender = _dropDownGender.SelectedValue.ToString();
            //    //string color = _dropDownColor.SelectedValue.ToString();
            //    //string size = _dropDownSize.SelectedValue.ToString();

            //    //int productID = wbsDAL.GetProduct(description, category, gender, color, size);
            //    p = wbsDAL.ProductSelectToCart(productID);

            //    AddToChartCart(p);

            //    //Get ProductID


            //    ////Get DataTable with all Info

            //if (Session["UserName"] != null)
            //{
            //    listChart = wbsDAL.GetProductInfo(productID, category, gender, color, size, quantity, 1);

            //    AddToChartCart(listChart); 
            //}
            //else
            //{
            //    listChart = wbsDAL.GetProductInfo(productID, category, gender, color, size, quantity, 2);
            //    AddToChartCart(listChart);
            //}
            //Response.Redirect("../Default");

            //    //////////////////////////////////////////////////////////////////////////////////////////////
            //    //    Should insert the order in Maste.Site.cs (shoppingCart) TODO  / Needs to reLogic it   //
            //    //////////////////////////////////////////////////////////////////////////////////////////////

            //    ////Check userName to be able to get CustomerID
            //    //string userName = (string)Session["UserName"];
            //    ////Get CustomerID to be able to get OrderID
            //    //int customerID = wbsDAL.GetCustomerLoggedID(userName);
            //    ////Get OrderID and insert into tblOrderProduct
            //    //int orderID = wbsDAL.InsertOrderProductTable(productID, quantity, customerID);
            //    //Response.Redirect("../OrderRec.aspx");
            //}
        }
}