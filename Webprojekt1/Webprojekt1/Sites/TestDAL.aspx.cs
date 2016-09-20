using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopDAL.ConnectedLayer;
using WebShopDAL.Models;


namespace Webprojekt1.Sites
{
    public partial class TestDAL : System.Web.UI.Page
    {
        public List<Product> GetAllProducts()
        {
            List<Product> allProductsList = new List<Product>();
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection($"Data Source=(local);Initial Catalog=WebbShop;Integrated Security=True");
            allProductsList = wbs.GetProducts();
            return allProductsList;
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}