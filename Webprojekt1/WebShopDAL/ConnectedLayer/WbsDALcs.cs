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

        public void InsertProduct(Product p)
        {
            string sql = $"Insert into tblProduct (ProductName, PriceUnit, Description, Color, Size,Stock, CategodyID) Values ('{p.ProductID}', '{p.ProductName}', '{p.Description}','{p.PriceUnit}', '{p.Color}', '{p.Size}', '{p.Stock}', '{p.CategoryID}')";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            string sql = $"Delete from tblProduct where ProductID = {id}";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateProduct(Product p)
        {
            string sql = $"Update tblProduct SET  ProductName = {p.ProductName}, PriceUnit = {p.PriceUnit} , Description = {p.Description}, Color = {p.Color}, Size = {p.Size},Stock = {p.Stock}, CategodyID = {p.CategoryID} Where ProductID = {p.ProductID}";
          
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertCustomer(Customer c)
        {
            string sql = $"Insert into tblCustomer (ProductName, PriceUnit, Description, Color, Size,Stock, CategodyID) Values ('{c.FirstName}', '{c.LastName}','{c.Email}','{c.Address}','{c.UserName}', '{c.Password}',  '{c.ZipCodeID}','{c.RabbatID}')";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateCustomer(Customer c, int id)
        {
            string sql = $"Update tblCustomer SET  FirstName = {c.FirstName}, LastName = {c.LastName} , Password = {c.Password}, ZipCodeID = {c.ZipCodeID}";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertOrder()
        {
           //SqlCommand _cmd

            
        }
           
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
                    string productName = (string)_sqlDtReader["ProductName"];
                    int priceUnit = (int)_sqlDtReader["PriceUnit"];
                    string description = (string)_sqlDtReader["Description"];
                    string color = (string)_sqlDtReader["Color"];
                    string size = (string)_sqlDtReader["Size"];
                    int stock = (int)_sqlDtReader["Stock"];
                    int categoryID = (int)_sqlDtReader["CategoryID"];

                    lsAllProduct.Add(new Product(productID, productName, priceUnit, description, color, size, stock, categoryID));
                }
                _sqlDtReader.Close();
               
            }
            return lsAllProduct;
        }


    }
}
