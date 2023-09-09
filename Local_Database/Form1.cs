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

namespace Local_Database
{
    public partial class Giris_Form : Form
    {
        public Giris_Form()
        {
            InitializeComponent();
        }

        

        private void giris_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Ogrenciler.mdf;Integrated Security = True"))
                {
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Select K_Ad,K_Sifre from Kullanicilar where K_Ad =@kad AND K_Sifre=@ksifre",connection);
                    komut.Parameters.AddWithValue("@kad", KAd_txtbox.Text);
                    komut.Parameters.AddWithValue("@ksifre", sifre_txtbox.Text);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        connection.Close(); 
                        MessageBox.Show("Giriş Başarılı");
                        Kayitlar frmKayitlar = new Kayitlar();
                        frmKayitlar.Show(); 
                    }
                    else
                    {
                        connection.Close();

                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
        }

        private void Giris_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
