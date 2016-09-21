using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL.Models;
using System.Data.SqlClient;

namespace WebShopDAL.ConnectedLayer
{
    public class WbsDAL
    {
        private SqlConnection _sqlConnection = null;


        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection { ConnectionString = connectionString };
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
        }
        public void InsertCustomer(Customer c)
        {
            string sql = $"Insert into tblCustomer (FirstName, LastName, Email, Address, UserName, Password, RabbatID) Values ('{c.FirstName}', '{c.LastName}','{c.Email}','{c.Address}','{c.UserName}', '{c.Password}',  '{c.ZipCodeID}','{c.RabbatID}')";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateCustomer( int id, string name)
        {
            string sql = $"Update tblCustomer SET  FirstName = {name} Where CustomerID = {id}";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertProductAdmin(Product p)
        {
            string sql = $"Insert into tblProduct (ProductBrand, PriceUnit, Description, Color, Size,Stock, CategodyID) Values ('{p.ProductBrand}', '{p.ProductDescription}','{p.PriceUnit}', '{p.Color}', '{p.Size}', '{p.Stock}', '{p.CategoryID}')";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProductAdmin(int id)
        {
            string sql = $"Delete from tblProduct where ProductID = {id}";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateProductAdmin(int id,string name)
        {
            string sql = $"Update tblProduct SET  ProductBrand = {name} Where ProductID = {id}";
          
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        //public void ProductSelectOptions(int id,string color, string size, int amount, int categoryID)//Get values from html form (customer)
        //{
        //    string sql = $"SELECT * FROM tblProduct   Color = {color}, Size = {size},Stock = {-amount}, CategodyID = {categoryID} Where ProductID = {id}";

        //    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //}
       
        public int InsertToOrderTbl(int custumerID)
        {
            var OrderDate = DateTime.Now;
            var DelivDate = OrderDate.AddDays(5);
            int moms = 25;
            int createdOrderID = 0;
            string sql = $"INSERT INTO tblOrder (OrderDate,DeliveryDate, Moms, CustomerID) OUTPUT INSERTED.ID VALUES ('@OrderDate','@DeliveryDate', '@Moms','@CustumerID')";
            using (SqlCommand _sqlCommand = new SqlCommand(sql, _sqlConnection))
            {
                _sqlCommand.Parameters.AddWithValue("@OrderDate", OrderDate);
                _sqlCommand.Parameters.AddWithValue("@DeliveryDate", DelivDate);
                _sqlCommand.Parameters.AddWithValue("@Moms", moms);
                _sqlCommand.Parameters.AddWithValue("@CustumerID", custumerID);
                _sqlConnection.Open();

                createdOrderID = (int)_sqlCommand.ExecuteScalar();

                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
                return createdOrderID;


            }
        }
        public void InsertOrderProductTable(int productID, int quantity, int customerID)
        {

            //SqlCommand _cmdInsertProductToOrderTable = new SqlCommand($"", _sqlConnection);
            int orderID = InsertToOrderTbl(customerID);
            using (SqlCommand _cmdInsertToOrderProductTbl = new SqlCommand($"INSERT INTO tblOrderProduct (ProductID,OrderID, Quantity) VALUES ('@ProductID','@OrderID', '@Quantity')", _sqlConnection))
            {
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@ProductID", productID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@OrderID", orderID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@Quantity", quantity);
              
            }

        }
        public void CrateOrderXML()
        {

        }//TODO
           
        public List<Product> GetProducts()
        {
            List<Product> lsAllProduct = new List<Product>();
            string sql = $"select * from tblProduct";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader _sqlDtReader = cmd.ExecuteReader();
                while (_sqlDtReader.Read())
                {
                    int productID = (int)_sqlDtReader["ProductID"];
                    string productBrand = (string)_sqlDtReader["ProductBrand"];
                    decimal priceUnit = (decimal)_sqlDtReader["PriceUnit"];
                    string productDescription = (string)_sqlDtReader["ProductDescription"];
                    string color = (string)_sqlDtReader["Color"];
                    string size = (string)_sqlDtReader["Size"];
                    int stock = (int)_sqlDtReader["Stock"];
                    int categoryID = (int)_sqlDtReader["CategoryID"];

                    lsAllProduct.Add(new Product(productID, productBrand, priceUnit, productDescription, color, size, stock, categoryID));
                }
                _sqlDtReader.Close();
               
            }
            return lsAllProduct;
        }


    }
}
