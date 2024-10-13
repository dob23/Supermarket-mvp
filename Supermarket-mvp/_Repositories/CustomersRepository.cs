using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomerRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CustomersAdd(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers (Document_Number, First_Name, Last_Name, Address, Birthday, Phone_Number, Email) VALUES (@Document_Number, @First_Name, @Last_Name, @Address, @Birthday, @Phone_Number, @Email)";
                command.Parameters.Add("@Document_Number", SqlDbType.NVarChar).Value = customerModel.Document_Number;
                command.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@Last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name; 
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.Date).Value = customerModel.Birthday;
                command.Parameters.Add("@Phone_Number", SqlDbType.NVarChar).Value = customerModel.Phone_Number;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void CustomersDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE Customer_Id = @Customer_id";
                command.Parameters.Add("@Customer_id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void CustomersEdit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers SET First_Name = @First_Name,
                                        Last_Name = @Last_Name,
                                        Document_Number = @Document_Number,
                                        Address = @Address,
                                        Birthday = @Birthday,
                                        Phone_Number = @Phone_Number,
                                        Email = @Email
                                        WHERE Customer_Id = @Customer_Id";
                command.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@Last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name; 
                command.Parameters.Add("@Document_Number", SqlDbType.NVarChar).Value = customerModel.Document_Number;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.Date).Value = customerModel.Birthday;
                command.Parameters.Add("@Phone_Number", SqlDbType.NVarChar).Value = customerModel.Phone_Number;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@Customer_Id", SqlDbType.Int).Value = customerModel.Customer_Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customer_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Customer_Id = (int)reader["Customer_Id"];
                        customerModel.First_Name = reader["First_Name"].ToString();
                        customerModel.Last_Name = reader["Last_Name"].ToString(); 
                        customerModel.Document_Number = reader["Document_Number"].ToString();
                        customerModel.Address = reader["Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Birthday"];
                        customerModel.Phone_Number = reader["Phone_Number"].ToString();
                        customerModel.Email = reader["Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerFirst_Name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers WHERE Customer_Id=@id or First_Name LIKE @first_Name + '%'
                                        ORDER by Customer_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@first_Name", SqlDbType.NVarChar).Value = customerFirst_Name;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Customer_Id = (int)reader["Customer_Id"];
                        customerModel.First_Name = reader["First_Name"].ToString();
                        customerModel.Last_Name = reader["Last_Name"].ToString();  
                        customerModel.Document_Number = reader["Document_Number"].ToString();
                        customerModel.Address = reader["Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Birthday"];
                        customerModel.Phone_Number = reader["Phone_Number"].ToString();
                        customerModel.Email = reader["Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }

            return customerList;
        }
    }
}
