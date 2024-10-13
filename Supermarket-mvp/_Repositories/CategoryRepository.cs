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
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void CategoryAdd(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@Name, @Description)";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void CategoryDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Product WHERE  Product_Category_Id = @Category_Id";
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM Categorie WHERE Category_Id = @Category_Id";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void CategoryEdit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories SET Categorie_Name = @name,
                                        Categorie_Description = @Description
                                        WHERE Categorie_Id = @Category_Id";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.Parameters.Add("@Category_Id", SqlDbType.Int).Value = categoryModel.Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Name"].ToString();
                        categoryModel.Description = reader["Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories WHERE Category_Id=@Category_Id or Name LIKE @Name+ '%'
                                      ORDER by Category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Name"].ToString();
                        categoryModel.Description = reader["Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }

            return categoryList;
        }
    }
}
