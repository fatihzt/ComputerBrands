using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComputerBrands
{
    public static class SqlHelpers
    {
        public static int CreateQuery(string query, IDictionary<string, object> parameters)
        {
            SqlConnection sqlConnection = GeneralDefinition.sqlConnection;
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = CommandType.Text;
            foreach (var item in parameters)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            try
            {
                sqlConnection.Open();
                int value = cmd.ExecuteNonQuery();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error! create query");
                return 0;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
