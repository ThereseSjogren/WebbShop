using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL.Models;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web;
using System.Data;

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
        //Registrate Customer
        public void InsertCustomer(Customer c)
        {
            string sql = $"Insert into tblCustomer (FirstName, LastName, Email, Address, UserName, Password, RabattID) Values ('{c.FirstName}', '{c.LastName}','{c.Email}','{c.Address}','{c.UserName}', '{c.Password}',  '{c.ZipCodeID}','{c.RabattID}')";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateCustomer(int id)
        {
            string sql = $"Update tblCustomer SET  Where CustomerID = {id}";

            using (SqlCommand cmd = new SqlCommand(sql, _sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        #region OrderProcess

        /// <summary>
        /// Order process that includes insert to order table, insert to productOrder table, check username
        /// </summary>
        /// <param name="custumerID"></param>
        /// <returns>Created order's ID</returns>
        public int InsertToOrderTbl(int custumerID)
        {
           
                //////////////////////////////////
                var OrderDate = DateTime.Now.Date;
                var DelivDate = OrderDate.AddDays(5).Date;
                int moms = 25;
                int createdOrderID = 0;
                string sql = @"INSERT INTO tblOrder (OrderDate,DeliveryDate, Moms, CustomerID) VALUES ("+OrderDate+","+DelivDate+", "+moms+","+custumerID+")";
                using (SqlCommand _sqlCommand = new SqlCommand(sql, _sqlConnection))
            {
                //_sqlCommand.Parameters.AddWithValue("@ProductID", productID);
                //_cmdInsertToOrderProductTbl.Parameters.AddWithValue("@OrderID", orderID);

                try
                {
                    _sqlCommand.ExecuteNonQuery();
                    string sql2 = $"SELECT @NewOrderID = SCOPE_IDENTITY()";
                    using (SqlCommand _sqlCommand2 = new SqlCommand(sql2, _sqlConnection))
                    {
                        /////////////////////////////////////////////////
                        SqlDataReader dataReader = _sqlCommand2.ExecuteReader();
                        while (dataReader.Read())
                        {
                            createdOrderID = (int)dataReader["@NewOrderID"];
                            return createdOrderID;

                        }
                        dataReader.Close();
                        dataReader.Dispose();
                        //////////////////////////////////////
                    }
                }
                catch (SqlException sqlex)
                {

                    throw new Exception($"{sqlex}");
                }
                    
                }
           return createdOrderID;

        }

           
        
        /// <summary>
        /// Calls InsertToOrderTbl(customerID) and creates a new row in ProductOrder table
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="quantity"></param>
        /// <param name="customerID"></param>
        public void InsertOrderProductTable(int productID, int quantity, int customerID)
        {

            //SqlCommand _cmdInsertProductToOrderTable = new SqlCommand($"", _sqlConnection);
            int orderID = InsertToOrderTbl(customerID);
            using (SqlCommand _cmdInsertToOrderProductTbl = new SqlCommand($"INSERT INTO tblOrderProduct (ProductID,OrderID, Quantity) VALUES (@ProductID,@OrderID, @Quantity)", _sqlConnection))
            {
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@ProductID", productID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@OrderID", orderID);
                _cmdInsertToOrderProductTbl.Parameters.AddWithValue("@Quantity", quantity);
                DataTable dr = new DataTable();
                using (SqlCommand cmdAllOrderDetails = new SqlCommand($"sp_GetAllOrderInfo @OrderID={orderID}", _sqlConnection))
                {
                    SqlDataReader _adapter = cmdAllOrderDetails.ExecuteReader();
                    dr.Load(_adapter);
                    _adapter.Close();
                }
            }
        }

        public int GetCustomerLoggedID(string userName)
        {
            int customerID;
            string numberOfCustomers = $"SELECT COUNT(*) FROM tblCustomer Where UserName = '{userName}'";
            using (SqlCommand cmd = new SqlCommand(numberOfCustomers, _sqlConnection))
            {
                customerID = (int)cmd.ExecuteScalar();
                if (customerID == 1)
                {
                    return customerID;
                }
                return customerID;


            }

        }

        public int GetProduct(string category, string gender, string color, string size)
        {
            string getProduct = $"SELECT p.ProductID FROM tblProduct AS p INNER JOIN tblCategory AS c ON p.CategoryID = c.CategoryID  WHERE CategoryName= '{category}' AND Gender= '{gender}' AND Color = '{color}' AND Size = '{size}' ";
            using (SqlCommand cmd = new SqlCommand(getProduct, _sqlConnection))
            {
                int productID = (int)cmd.ExecuteScalar();
                return productID;
            }

        }
        #endregion

        #region ProductAdministration
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



                    lsAllProduct.Add(new Product(productBrand, priceUnit, productDescription, color, size));
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
                                    //Session["NewUserEmail"] = email;
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
                                    //Session["New"] = userName;
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
        #endregion





    }
}
