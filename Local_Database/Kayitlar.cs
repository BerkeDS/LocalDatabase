using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Local_Database
{
    public partial class Kayitlar : Form
    {
        public Kayitlar()
        {
            InitializeComponent();
        }

        private void Kayitlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrencilerDataSet.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.ogrencilerDataSet.Ogrenci);
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Ogrenciler.mdf;Integrated Security = True"))
                {
                    
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenci", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                }
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Ogrenciler.mdf;Integrated Security = True"))
                {

                    SqlCommand komut = new SqlCommand("Select * from Ogrenci", connection);
                    

                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
