﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog=ETrade; integrated security=true");
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            SqlDataReader reader =  command.ExecuteReader();

            List<Product> products = new List<Product>();


            //Aşağıdaki kodda her okuduğu product'ı Add ile listeye ekliyor
            while (reader.Read())   //Okuyabildiğin kadar oku ve döngüde döndür
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToInt32(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;
        }
    }
}