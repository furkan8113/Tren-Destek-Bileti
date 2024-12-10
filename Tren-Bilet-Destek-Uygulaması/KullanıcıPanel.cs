using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tren_Destek_Bileti_Gerçek
{
    public partial class KullanıcıPanel : Form
    {
        private string connectionString = @"Data Source=FURKANN\SQLEXPRESS;Initial Catalog=tren_destek;Integrated Security=True";

        public KullanıcıPanel()
        {
            InitializeComponent();
        }

        private void KullanıcıPanel_Load(object sender, EventArgs e)
        {
            LoadTickets(); // Mevcut biletleri yükler.
            LoadCategories(); // Kategorileri yükler.
        }

        private void LoadTickets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT bilet_id, kategori, baslik, durum, olusturulma_tarihi FROM biletler WHERE kullanici_id = @kullaniciId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", GetLoggedInUserId());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewTickets.DataSource = table; // Biletleri DataGridView'e bağlar.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT kategori FROM kategoriler"; // 'kategoriler' tablosundaki kategorileri alır.
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbKategori.Items.Clear();
                    while (reader.Read())
                    {
                        cmbKategori.Items.Add(reader["kategori"].ToString());
                    }
                    if (cmbKategori.Items.Count > 0)
                    {
                        cmbKategori.SelectedIndex = 0; // Varsayılan olarak ilk kategoriyi seç.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private int GetLoggedInUserId()
        {
            // Oturum açmış kullanıcının ID'sini almak için.
            return 1; // Şimdilik sabit değer.
        }

     
        private void btnBiletOlustur_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO biletler (kullanici_id, kategori, baslik, aciklama) VALUES (@kullaniciId, @kategori, @baslik, @aciklama)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", GetLoggedInUserId());
                    cmd.Parameters.AddWithValue("@kategori", cmbKategori.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@baslik", txtBaslik.Text);
                    cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilet başarıyla oluşturuldu.");
                    LoadTickets();

                    // Form alanlarını temizler.
                    txtBaslik.Clear();
                    txtAciklama.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnDurumGor_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count > 0)
            {
                int selectedTicketId = Convert.ToInt32(dataGridViewTickets.SelectedRows[0].Cells["bilet_id"].Value);
                MessageBox.Show($"Seçilen biletin durumu: {dataGridViewTickets.SelectedRows[0].Cells["durum"].Value}");
            }
            else
            {
                MessageBox.Show("Lütfen bir bilet seçin.");
            }
        }
    }
}
