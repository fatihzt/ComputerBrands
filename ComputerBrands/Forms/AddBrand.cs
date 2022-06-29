using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBrands
{
    public partial class AddBrandFrom : Form
    {
        private int Id;
        private bool forupdate;


        public AddBrandFrom()
        {
            InitializeComponent();
        }
        public AddBrandFrom(int id)
        {
            Id= id;
            forupdate= true;
            InitializeComponent();
            string sql = "select top 1 [Id],[BrandName],[BrandFoundationYear],[BrandLocalCountry] from BrandInformation where Id= @id";
            SqlConnection sqlConnection = GeneralDefinition.sqlConnection;
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue(parameterName: "@id", Id);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    namebox.Text = sqlDataReader.GetString(1);
                    yearbox.Text = sqlDataReader.GetString(2);
                    countrybox.Text = sqlDataReader.GetString(3);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error!");
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }


        }

        private void addbrandbutton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands(Id, namebox.Text, yearbox.Text, countrybox.Text);

            if (forupdate)
            {
                /*cmd = new SqlCommand(cmdText: "update BrandInformation set BrandName=@bn,BrandFoundationYear=@bf,BrandLocalCountry=@bl where Id=@id", sqlConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;*/
                Sql.UpdateBrands(brands);
                Close();
            }
            else
            {
                Sql.AddBrands(brands);
            }
            Close();   
        }
    }
}
