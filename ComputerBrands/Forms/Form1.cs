using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBrands
{
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int id)
        {
            Id = id;
            InitializeComponent();

        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrandFrom addBrand = new AddBrandFrom();
            addBrand.ShowDialog();
            TakeBrandInformation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TakeBrandInformation();
        }
        void TakeBrandInformation()
        {
            SqlConnection sqlConnection = GeneralDefinition.sqlConnection;
            SqlCommand cmd = new SqlCommand(cmdText: "select [Id],[BrandName],[BrandFoundationYear],[BrandLocalCountry] from BrandInformation", sqlConnection);
           
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                BrandList.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    BrandList.Rows.Add(sqlDataReader.GetInt32(i:0),sqlDataReader.GetString(i:1),sqlDataReader.GetString(i:2),sqlDataReader.GetString(i:3));

                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error!! take");
            }
            finally
            {
                if(sqlConnection.State!= ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void removeBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BrandList.SelectedRows.Count == 0)
            {
                return;
            }
            object value = BrandList.SelectedRows[0].Cells[0].Value;
            int Id = (int)value;
            Sql.DeleteBrands(Id);
            TakeBrandInformation();
            
        }

        private void updateBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BrandList.SelectedRows.Count == 0)
            {
                return;
            }
            object value = BrandList.SelectedRows[0].Cells[0].Value;
            int id = (int)value;
             
            AddBrandFrom addBrand = new AddBrandFrom(id);
            addBrand.ShowDialog();
            TakeBrandInformation();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string b_name = textsearch.Text;
            string sql = "select [Id],[BrandName],[BrandFoundationYear],[BrandLocalCountry] from BrandInformation where BrandName like '%"+b_name+"%'";
            SqlConnection sqlConnection = GeneralDefinition.sqlConnection;
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.CommandType = CommandType.Text;
            
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dataTable=new DataTable();
                
                while (sqlDataReader.Read())
                {
                    
                    BrandList.Rows[0].Cells[1].Value = sqlDataReader.GetString(1);
                    BrandList.Rows[0].Cells[2].Value = sqlDataReader.GetString(2);
                    BrandList.Rows[0].Cells[3].Value = sqlDataReader.GetString(3);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error!");
            }
            
            
            sqlConnection.Close();
        }
    }
}
