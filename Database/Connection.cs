using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Database
{
    public class Connection
    {
        public DataTable EjecutarConsulta(SqlCommand cmd)
        {
            string conx = "Data Source=DESKTOP-E0BU1LI\\SQLEXPRESS;Initial Catalog=ODEPADB;Integrated Security=True";
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.Connection = new SqlConnection(conx);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex.Message);
            }
            return dt;
        }
    }
}
