using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBrands
{
    public class Sql
    {
        /*public static void AddBrands1(Brands brands)
        {
            string sql = "insert into BrandInformation ([BrandName],[BrandFoundationYear],[BrandLocalCountry]) values (@bn,@bf,@bl)";
            SqlConnection sqlConnection = GeneralDefinition.sqlConnection;
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@bn", SqlDbType.VarChar).Value = brands.BrandName;
            cmd.Parameters.Add("@bf", SqlDbType.VarChar).Value = brands.BrandFoundationYear;
            cmd.Parameters.Add("@bl", SqlDbType.VarChar).Value = brands.BrandLocalCountry;
            try
            {
                int value = cmd.ExecuteNonQuery();
                MessageBox.Show(text: $"Added is{(value > 0 ? "success" : "'nt success")}", caption: value > 0 ? "Information" : "Error", MessageBoxButtons.OK, value > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error added!");
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }


        }*/
    
        public static void AddBrands(Brands brands)
        {
            string sql = "insert into BrandInformation ([BrandName],[BrandFoundationYear],[BrandLocalCountry]) values (@bn,@bf,@bl)";

            var parameters = new Dictionary<string, object>();
            parameters.Add("@bn", brands.BrandName);
            parameters.Add("@bf", brands.BrandFoundationYear);
            parameters.Add("@bl", brands.BrandLocalCountry);
            int value = SqlHelpers.CreateQuery(sql, parameters);

            MessageBox.Show(text: $"Added is{(value > 0 ? "success" : "'nt success")}", caption: value > 0 ? "Information" : "Error", MessageBoxButtons.OK, value > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        }
        public static void UpdateBrands(Brands brands)
        {
            string sql = "update BrandInformation set BrandName=@bn,BrandFoundationYear=@bf,BrandLocalCountry=@bl where Id=@id";
            var parameters=new Dictionary<string, object>();
            parameters.Add("@id", brands.Id);
            parameters.Add("@bn",brands.BrandName);
            parameters.Add("@bf",brands.BrandFoundationYear);
            parameters.Add("@bl",brands.BrandLocalCountry);
            int value =SqlHelpers.CreateQuery(sql,parameters);

            MessageBox.Show(text: $"Upload is{(value > 0 ? "success" : "'nt success")}", caption: value > 0 ? "Information" : "Error", MessageBoxButtons.OK, value > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            
        }
        public static void DeleteBrands(int id)
        {
            string sql = "Delete BrandInformation where Id=@id";
            var parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            int value = SqlHelpers.CreateQuery(sql, parameters);
            MessageBox.Show(text: $"Delete is{(value > 0 ? "success" : "'nt success.")}", caption: value > 0 ? "Information" : "Error",
                    MessageBoxButtons.OK, value > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            
            }
        }
    }
