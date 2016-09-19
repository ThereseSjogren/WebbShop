using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WebShopDAL.Models;

namespace WebShopDAL.ConnectedLayer
{
    class WebShopDAL
    {
        private SqlConnection _sqlConnection = null;

        
        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection { ConnectionString = connectionString };
            _sqlConnection.Close();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
        }

        public void InsertProduct(Product p)
        {
            string sql = $"Insert into Product (ProductID, ProductName, Category, Size) Values ('{p.ProductID}', '{p.ProductName}', '{p.Category}', '{p.Size}')";

            using (SqlCommand cmd = new SqlCommand(sql,_sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            string sql = $"Delete from Product where ProductID = {id}";
        }
        public void UpdateProduct()
        {

        }




    }
}
