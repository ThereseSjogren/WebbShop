using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.SessionState;
using System.Web;
using WebShopDAL.Models;
using WebShopDAL.ConnectedLayer;
using System.Reflection;
using System.Web.Optimization;
using System.Web.Routing;

using System.Configuration;

using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;


namespace Webprojekt1.Models
{
    public class ShoppingCartActions 
    {
        public List<CartItem> shoppingCartItems  { get; set; }
        public string ShoppingCartID { get; set; }
        public const string CartSessionKey = "CartID";

        public void AddToCart(int ID)
        {
            
            WbsDAL wbs = new WbsDAL();
            wbs.OpenConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
            

            ShoppingCartID = GetCartID();
            shoppingCartItems = (List<CartItem>)HttpContext.Current.Session["AddToChartCart"];
            var cartItem = shoppingCartItems.SingleOrDefault(c => c.CartID == ShoppingCartID && c.ProductID == ID);
            if (cartItem == null)
            {
                shoppingCartItems.Add(new CartItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    CartID = ShoppingCartID,                
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    ProductID = ID,
                    Product = (Product)shoppingCartItems.Where(p => p.ProductID == ID)
                
                });
                HttpContext.Current.Session["AddToChartCart"] = shoppingCartItems;
            }
            else
            {
                cartItem.Quantity++;
            }
            


        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public string GetCartID()
        {
            ////////////////////////////////
            // Get a user session name    //
            ///////////////////////////////

            //Check if Cart session is null
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace((string)HttpContext.Current.Session["UserName"]))
                {
                    HttpContext.Current.Session[CartSessionKey] = (string)HttpContext.Current.Session["UserName"];
                }
            }
            else
            {
                //Create a random GUID (UserID)
                Guid tempCartID = Guid.NewGuid();
                HttpContext.Current.Session[CartSessionKey] = tempCartID;
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }
        public List<CartItem> GetCartItems()
        {
            List<CartItem> giveCartItems = new List<CartItem>();
            shoppingCartItems = (List<CartItem>)HttpContext.Current.Session["AddToChartCart"];
            foreach (CartItem cart in shoppingCartItems)
            {
                if (cart.CartID == ShoppingCartID)
                {
                    giveCartItems.Add(cart);
                }
            }
            return giveCartItems;
        }
    }

}