using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL.Models;
using System.Data.SqlClient;
using System.Data.Sql;


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
        public void UpdateCustomer( int id)
        {
            string sql = $"Update tblCustomer SET  Where CustomerID = {id}";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        //public void InsertProductAdmin(Product p)
        //{
        //    string sql = $"Insert into tblProduct (ProductBrand, PriceUnit, Description, Color, Size,Stock, CategodyID) Values ('{p.ProductBrand}', '{p.ProductDescription}','{p.PriceUnit}', '{p.Color}', '{p.Size}', '{p.Stock}', '{p.CategoryID}')";

        //    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void DeleteProductAdmin(int id)
        //{
        //    string sql = $"Delete from tblProduct where ProductID = {id}";
        //    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        //public void UpdateProductAdmin(int id)
        //{
        //    string sql = $"Update tblProduct SET  Where ProductID = {id}";
          
        //    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        ////public void ProductSelectOptions(int id,string color, string size, int amount, int categoryID)//Get values from html form (customer)
        ////{
        ////    string sql = $"SELECT * FROM tblProduct   Color = {color}, Size = {size},Stock = {-amount}, CategodyID = {categoryID} Where ProductID = {id}";

        ////    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
        ////    {
        ////        cmd.ExecuteNonQuery();
        ////    }
        ////}
       
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
            using (SqlCommand _cmdInsertToOrderProductTbl = new SqlCommand($"INSERT INTO tblOrderProduct (ProductID,OrderID, Quantity) VALUES (@ProductID,@OrderID, @Quantity)", _sqlConnection))
            {
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@ProductID", productID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@OrderID", orderID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@Quantity", quantity);
              
            }

        }
        public void GetCustomerLoggedID(bool isLogged)
        {

        }
        
        public void InsertCustomersOrder(int customerID)
        {

            //if ()
            //{
            //    string sql = $"INSERT INTO tblOrder(Order)";

            //    using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            //    {
            //        cmd.ExecuteNonQuery();
            //    } 
            //}
        }
        public void CrateOrderXML()
        {

        }//TODO
        public int GetProduct(string color, string size)
        {
            string getProduct = $"SELECT ProductID FROM tblProduct WHERE Color = '{color}' AND Size = '{size}' ";
            using (SqlCommand cmd = new SqlCommand(getProduct, _sqlConnection))
            {
                int productID = (int)cmd.ExecuteScalar();
                return productID;
            }
            
        }
        public List<Product> lsDescriptionProduct(int id)
        {
            List<Product> lsAllProduct = new List<Product>();
            string sql = $"SELECT ProductBrand, PriceUnit, ProductDescription, Color, Size from tblProduct Where ProductID = {id} ";
            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                SqlDataReader _sqlDtReader = cmd.ExecuteReader();
                while (_sqlDtReader.Read())
                {
                    
                    string productBrand = (string)_sqlDtReader["ProductBrand"];
                    decimal priceUnit = (decimal)_sqlDtReader["PriceUnit"];
                    string productDescription = (string)_sqlDtReader["ProductDescription"];
                    string color = (string)_sqlDtReader["Color"];
                    string size = (string)_sqlDtReader["Size"];
                    
                    

                    lsAllProduct.Add(new Product( productBrand, priceUnit, productDescription, color, size));
                }
                _sqlDtReader.Close();

            }
            return lsAllProduct;



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

        public int ReturnUserLogedIn(string userName, string password)
        {
            int customerID = 0;
            bool islogged;
            //Check if user name is an email or a proper userName
            if (userName.Contains("@"))
            {
                //Count if any customer with this email
                string checkEmail = $"SELECT count(*) FROM tblCustomer where Email = '{userName}'";
                using (SqlCommand cmd = new SqlCommand(checkEmail, _sqlConnection))
                {
                    //ExecuteScalar combined with the count sql query, returns number of users with the inputed user
                    int tempEmail = (int)cmd.ExecuteScalar();
                    if (tempEmail == 1)
                    {
                        //If it exists check the password
                        string checkPasswordQuery = $"Select Password from tblCustomer where Email = '{userName}'";
                        using (SqlCommand comPassword = new SqlCommand(checkPasswordQuery, _sqlConnection))
                        {
                            string pass = (string)comPassword.ExecuteScalar();
                            if (pass == password)
                            {
                                //If password correct select user and keep it in a variable to turn it back (needed to place the order of an eventual purchase)
                                string selectCustomer = $"Select * from tblCustomer where Email = '{userName}'";
                                using (SqlCommand comPassword2 = new SqlCommand(checkPasswordQuery, _sqlConnection))
                                {
                                    customerID = (int)comPassword2.ExecuteScalar();
                                    islogged = true;
                                    //Session["New"] = email;
                                    //("Password is correct");
                                    //Response.Redirect("../Products.aspx");                                                            
                                }
                            }
                            //else
                            //If not
                            //islogged = false;
                            //Response.Write("Password is not correct");
                        }
                    }
                    //else
                    //    islogged = false;

                    //Response.Write("UserName is not correct is not correct");                   
                }
                return customerID;
            }
            else
            {
                string checkUser = $"SELECT count(*) FROM tblCustomer WHERE UserName = '{userName}'";
                using (SqlCommand cmd2 = new SqlCommand(checkUser, _sqlConnection))
                {
                    //Returns number of users with the inputed user
                    int tempUser = (int)cmd2.ExecuteScalar();
                    if (tempUser == 1)
                    {
                        string checkPasswordQuery = $"Select Password from tblCustomer where UserName = '{userName}'";
                        using (SqlCommand comPassword = new SqlCommand(checkPasswordQuery, _sqlConnection))
                        {
                            string pass = (string)comPassword.ExecuteScalar();
                            if (pass == password)
                            {
                                //If password correct select user and keep it in a variable to turn it back (needed to place the order of an eventual purchase)
                                string selectCustomer = $"Select * from tblCustomer where UserName = '{userName}'";
                                using (SqlCommand comPassword2 = new SqlCommand(checkPasswordQuery, _sqlConnection))
                                {
                                    customerID = (int)comPassword2.ExecuteScalar();
                                    islogged = true;
                                    //Session["New"] = email;
                                    //("Password is correct");
                                    //Response.Redirect("../Products.aspx");                          
                                }
                                //islogged = true;                               
                            }
                            //else
                            //islogged = false;
                        }
                    }
                    //else
                    //islogged = false;                   
                }
                //return islogged;
                return customerID;
            }

        }//TODO Needs to return customerID


    }
}
