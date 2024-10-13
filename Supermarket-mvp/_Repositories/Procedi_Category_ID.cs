using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class Procedi_Category_ID
    {
        Connection connect = new Connection();
        public DataTable Cargar_ID()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SP_CARGA_ID", connect.LlaveForanea());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}
