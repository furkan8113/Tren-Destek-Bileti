using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tren_Destek_Bileti_Gerçek;

namespace Tren_Destek_Bileti_Gercek
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=FURKANN\\SQLEXPRESS;Initial Catalog=tren_destek;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        bool yonetici = (bool)reader["yonetici"];

                        if (yonetici)
                        {
                            AdminPanel adminPanel = new AdminPanel();
                            adminPanel.Show();
                        }
                        else
                        {
                            KullanıcıPanel kullaniciPanel = new KullanıcıPanel();
                            kullaniciPanel.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
