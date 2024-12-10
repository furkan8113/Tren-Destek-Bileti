using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tren_Destek_Bileti_Gerçek
{
    public partial class AdminPanel : Form
    {
        private string connectionString = @"Server=FURKANN\SQLEXPRESS;Database=tren_destek;Trusted_Connection=True;";

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadTickets(); // Form yüklendiğinde biletleri listele.
            LoadCategories(); // Mevcut kategorileri listele.
        }

        private void LoadTickets(string category = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT bilet_id, kullanici_id, kategori, baslik, durum, olusturulma_tarihi FROM biletler";

                    if (!string.IsNullOrEmpty(category))
                    {
                        query += " WHERE kategori = @kategori";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(category))
                    {
                        cmd.Parameters.AddWithValue("@kategori", category);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewTickets.DataSource = table; // Gelen veriyi DataGridView'e bağla.
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
                    string query = "SELECT DISTINCT kategori FROM biletler";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbKategoriFiltre.Items.Clear();
                    cmbKategoriFiltre.Items.Add("Tümü");
                    while (reader.Read())
                    {
                        cmbKategoriFiltre.Items.Add(reader["kategori"].ToString());
                    }

                    cmbKategoriFiltre.SelectedIndex = 0; // Varsayılan olarak "Tümü" seçili.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
       private void btnFiltrele_Click_1(object sender, EventArgs e)
        {
            string selectedCategory = cmbKategoriFiltre.SelectedItem.ToString();
            if (selectedCategory == "Tümü")
            {
                LoadTickets();
            }
            else
            {
                LoadTickets(selectedCategory);
            }
        }

        private void btnCevapla_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count > 0)
            {
                int ticketId = Convert.ToInt32(dataGridViewTickets.SelectedRows[0].Cells["bilet_id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO cevaplar (bilet_id, admin_id, cevap_metni) VALUES (@biletId, @adminId, @cevapMetni)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@biletId", ticketId);
                        cmd.Parameters.AddWithValue("@adminId", 1); // Şimdilik admin ID sabit alınabilir.
                        cmd.Parameters.AddWithValue("@cevapMetni", txtCevap.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cevap başarıyla gönderildi.");
                        txtCevap.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bilet seçin.");
            }
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count > 0)
            {
                int ticketId = Convert.ToInt32(dataGridViewTickets.SelectedRows[0].Cells["bilet_id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE biletler SET durum = 'Kapalı' WHERE bilet_id = @biletId";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@biletId", ticketId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bilet başarıyla kapatıldı.");
                        LoadTickets();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bilet seçin.");
            }
        }
    }
}
