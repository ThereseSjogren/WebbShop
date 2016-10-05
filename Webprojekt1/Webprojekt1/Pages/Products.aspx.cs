using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using WebShopDAL.ConnectedLayer;
using WebShopDAL.Models;
using System.Data;
using System.Web.ModelBinding;
using System.Web.Routing;



namespace Webprojekt1
{
    public partial class Products : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ////////////////////////
            //  LOAD All Products //
            ////////////////////////

            int number;
            string markupHTML = "";
            List<Product> allProductList = new List<Product>();
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
            allProductList = wbs.GetListOfAllProducts();
            foreach (Product p in allProductList)
            {
                number = Decimal.ToInt32(p.PriceUnit);
                markupHTML += $"<div class=\"col-md-3 box\">" +
                               $"<div class=\"cover left\">"+
                                 $"<div class =\"show show-second\" >" +
                                    $"<img src =\"/Images/{p.ImageURL}\" alt =\"Generic placeholder thumbnail\">" +

                                 $"</div>" +                                
                                 $"<div class=\"mask\">" +

                                 $"<div class = \"caption\">" +
                                    $"<h3>{p.ProductBrand}</h3>" +
                                    //$"<h2 class=\"title\">{p.ProductBrand}</h2>" +
                                 $"</div>" +
                                
                                     $"Price: {number} SEK" +
                                   $"</a>" +
                                 $"</div>" +
                               $"</div>" +
                              $"</div>";

        //              < div class="col-1-4">
        //    <div class="cover left">
        //        <div class="show show-second">
        //            <img src = "../../../Pictures/child/T-shirt/77.jpg" />

        //            < div class="mask">
        //                <h2>Helly Hansen</h2>
        //                <p>$80.00</p>
        //                <a href = "ShoppingCartMen/MenCartTShirt/MTshirt4.aspx" class="more">More info</a>
        //            </div>
        //        </div>
        //    </div>
        //</div>


            }
            InsertedProducts.InnerHtml = markupHTML;
        }
        //public IQueryable<Product> GetProducts([QueryString("id")] int? ProductID)
        //{
        //    WbsDAL wbs = new WbsDAL();
        //    wbs.OpenConnection("Data Source=.;Initial Catalog=WebbShop;Integrated Security=True");

        //    IQueryable<Product> getProductWithID = (IQueryable<Product>)wbs.GetListOfAllProducts();
        //    if (ProductID.HasValue && ProductID > 0)
        //    {
        //        getProductWithID.Where(x => x.ProductID == ProductID).AsQueryable();
        //    }
        //    else
        //    {
        //        getProductWithID = null;
        //    }
        //    return getProductWithID;

        //}

    }
}
#region MyRegion
//protected void CreateFilter_Click(object sender, EventArgs e)
//{

//    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
//    con.Open();

//    //string sql = @"select count(*) from tblProduct AS p 
//    //                INNER JOIN tblCategory AS c ON p.CategoryID = c.CategoryID 
//    //                Where CategoryName = 'T-Shirt' AND Color = '@Color' AND Size = '@Size'";
//    //using (SqlCommand _sqlCommand = new SqlCommand(sql, con))
//    //{
//    string sql = @"select p.ProductID from tblProduct AS p 
//                    INNER JOIN tblCategory AS c ON p.CategoryID = c.CategoryID 
//                    Where  Color = '@Color' AND Size = '@Size'";
//    using (SqlCommand _sqlCommand = new SqlCommand(sql, con))
//    {
//        _sqlCommand.Parameters.AddWithValue("@Size", _dropDownSize.SelectedValue);
//        _sqlCommand.Parameters.AddWithValue("@Color", _dropDownColor.SelectedValue);


//        List<Product> filt = new List<Product>();
//        SqlDataReader reader = _sqlCommand.ExecuteReader();
//        while (reader.Read())
//        {

//            try
//            {
//                int productID = (int)reader["ProductID"];
//                string color = (string)reader["Color"];
//                string size = (string)reader["Size"];
//                Product p = new Product(productID, color, size);
//                filt.Add(p);
//                GridView1.DataSource = filt;
//                GridView1.DataBind();
//            }
//            catch (SqlException ex)
//            {

//                Response.Write(ex.Message);
//            }
//        }
//      }

//    }
//} 
#endregion

