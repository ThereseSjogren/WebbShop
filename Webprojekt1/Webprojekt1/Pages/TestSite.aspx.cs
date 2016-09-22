using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopDAL.ConnectedLayer;
using WebShopDAL.Models;
using System.Web.ModelBinding;

namespace Webprojekt1.Pages
{
    public partial class TestSite : System.Web.UI.Page
    {
        public IQueryable<Product> GetAllProducts([Control("productsDropDownList")]string productBrand = "")
        {
            List<Product> allProductsList = new List<Product>();
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection($"Data Source=(local);Initial Catalog=WebbShop;Integrated Security=True");
            allProductsList = wbs.GetProducts();

            return string.IsNullOrEmpty(productBrand) ?
                wbs.GetProducts().AsQueryable() :
                wbs.GetProducts().Where(x => x.ProductBrand == productBrand).AsQueryable();

        }
        public void DeleteProduct(int productID)
        {
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection($"Data Source=(local);Initial Catalog=WebbShop;Integrated Security=True");
            wbs.DeleteProductAdmin(productID);

        }
        public void UpdateProduct(int productID, string name)
        {
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection($"Data Source=(local);Initial Catalog=WebbShop;Integrated Security=True");
            wbs.UpdateProductAdmin(productID, name);


        }

        public IEnumerable<Product> GetBrands()
        {
            IEnumerable<Product> productList = new List<Product>();

            WbsDAL invDAL = new WbsDAL();
            invDAL.OpenConnection($"Data Source=(local); Integrated Security = true; Initial Catalog=WebbShop");

            productList = invDAL.GetProducts();
            productList.Select(x => new { x.ProductBrand }).Distinct();


            return productList;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}