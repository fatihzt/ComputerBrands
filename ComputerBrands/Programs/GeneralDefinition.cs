using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBrands
{
    static class GeneralDefinition
    {
        public static string ConnectionSentence => ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        public static SqlConnection sqlConnection = new SqlConnection(ConnectionSentence);
    }
}
