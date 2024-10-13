using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductsRepository
    {

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void ProductAdd(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES (@Name, @Price, @Stock, @category_Id)";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@Price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@Stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@Category_Id", SqlDbType.Int).Value = productsModel.Category_Id;
                command.ExecuteNonQuery();
            }
        }

        public void ProductDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE Products_Id = @Product_Id";
                command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void ProductEdit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products SET Product_Name = @Name,
                                        Price = @Price,
                                        Stock = @Stock,
                                       Category_Id = @category_Id
                                        WHERE Product_Id = @Id";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@Price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@Stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@Category_Id", SqlDbType.Int).Value = productsModel.Category_Id;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsModel.Product_Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Product_Id = (int)reader["Product_Id"];
                        productsModel.Name = reader["Name"].ToString();
                        productsModel.Price = (int)reader["Price"];
                        productsModel.Stock = (int)reader["Stock"];
                        productsModel.Category_Id = (int)reader["Category_Id"];
                        productList.Add(productsModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product WHERE Product_Id=@id or Name LIKE @Name+ '%'
                                      ORDER by Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Product_Id = (int)reader["Product_Id"];
                        productsModel.Name = reader["Name"].ToString();
                        productsModel.Price = (int)reader["Price"];
                        productsModel.Stock = (int)reader["Stock"];
                        productsModel.Category_Id = (int)reader["PCategory_Id"];
                        productsList.Add(productsModel);
                    }
                }
            }

            return productsList;
        }

    }
}