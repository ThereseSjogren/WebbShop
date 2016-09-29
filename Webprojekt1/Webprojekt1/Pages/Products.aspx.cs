﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using WebShopDAL.ConnectedLayer;
using WebShopDAL.Models;
using System.Data;
using System.Web.ModelBinding;

namespace Webprojekt1
{
    public partial class Products : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateFilter_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebbShopConnectionString"].ConnectionString);
            con.Open();

            string sql = $"select productID from tblProduct AS p INNER JOIN tblCategory AS c ON p.CategoryID = c.CategoryID Where CategoryName= 'category' And Color = 'color' AND Size = 'size'";
            using (SqlCommand _sqlCommand = new SqlCommand(sql, con))
            {
                _sqlCommand.Parameters.AddWithValue("Size", _dropDownSize.SelectedValue);
                _sqlCommand.Parameters.AddWithValue("Color", _dropDownColor.SelectedValue);
                _sqlCommand.ExecuteNonQuery();

                List<Product> filt = new List<Product>();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    int productID = (int)reader["ProductID"];
                    string color = (string)reader["Color"];
                    string size = (string)reader["Size"];
                    Product p = new Product(productID, color, size);
                    filt.Add(p);
                    GridView1.DataSource = filt;
                    GridView1.DataBind();
                    
                }
            }
        }
    }
}