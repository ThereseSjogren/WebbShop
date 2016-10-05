using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebShopDAL.Models;

namespace Webprojekt1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start(object sender, EventArgs e)
        {
<<<<<<< HEAD
            List<CartItem> list = new List<CartItem>();

            Session["AddToChartCart"] = list;
            
=======
            List<Product> list = new List<Product>();
            List<Product> searchedlist = new List<Product>();

            Session["AddToChartCart"] = list;
            Guid guid = Guid.NewGuid();
            Session["GUID"] = guid;
            Session["SearchedProduct"] = searchedlist;
>>>>>>> 0b2811b59a773a6745ac4d6fc346f1d0e0c86142
        }

    }
}