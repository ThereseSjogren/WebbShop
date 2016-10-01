using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL.Models
{
    public class ProductOrderInfoChartCart
    {
        public int ProductID { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string CategoryName { get; set; }
        public decimal PriceUnit { get; set; }
        public int RabattID { get; set; }
        public int Quantity { get; set; }       
        
        public decimal Price { get; set; }
        public decimal TotalWithDiscount { get; set; }
        public decimal TotalWithTax { get; set; }

        


        public ProductOrderInfoChartCart(int productID, string brand, string color, string size, string categoryName, decimal priceUnit, int rabattID, int quantity, decimal price, decimal totalWithDiscount, decimal totalWithTax)
        {
            ProductID = productID;
            Brand = brand;
            Color = color;
            Size = size;
            CategoryName = categoryName;
            PriceUnit = priceUnit;
            RabattID = rabattID;
            Quantity = quantity;            
            Price = Price;
            TotalWithDiscount = totalWithTax;
            TotalWithTax = totalWithTax;

        }
        public void DeleteProductFromChart(List<ProductOrderInfoChartCart> chartList, int productID)
        {
            chartList.Select(x => x.ProductID == productID);
            //chartList.RemoveAt(x);

        }
    }
}
