using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class Connection
    {
        public SqlConnection LlaveForanea()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);

            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            else
            {
                connect.Open();
            }
            return connect;
        }
    }
}
