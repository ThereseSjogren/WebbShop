using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL.Models
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public bool logged { get; set; } //If logged apply discount
        
    }
}
