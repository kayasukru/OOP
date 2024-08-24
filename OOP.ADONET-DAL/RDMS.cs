using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ADONET_DAL
{
    public static class RDMS
    {

        private static string connectionString = @"Data Source=SKYN\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;";

        public static int SqlNonQuery(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    cmd.Connection = conn;

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static DataSet SqlReader(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;

                    var sda = new SqlDataAdapter(cmd);

                    var ds = new DataSet();

                    sda.Fill(ds);

                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
