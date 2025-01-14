using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_muzik : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;

        private int selectedEserId = -1; // Hafızadaki eser_id

        public Form_muzik()
        {
            InitializeComponent();
        }

        private void Form_muzik_Load(object sender, EventArgs e)
        {
            LoadMuzikData();
        }

        private void LoadMuzikData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Müzik";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridControl1.DataSource = table;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txteseradi.Text) || string.IsNullOrWhiteSpace(txteserurl.Text))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Müzik (eser_adı, eser_url) VALUES (@ad, @url)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txteseradi.Text);
                        cmd.Parameters.AddWithValue("@url", txteserurl.Text);
                        cmd.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("Eser başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMuzikData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Ekleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (selectedEserId == -1)
            {
                XtraMessageBox.Show("Lütfen silmek istediğiniz eseri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show("Bu eseri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Müzik WHERE eser_id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedEserId);
                        cmd.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("Eser başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMuzikData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txteseradi.Text))
            {
                XtraMessageBox.Show("Lütfen aramak istediğiniz eser adını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Müzik WHERE eser_adı LIKE @ad";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ad", "%" + txteseradi.Text + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridControl1.DataSource = table;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Arama işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (selectedEserId == -1 || string.IsNullOrWhiteSpace(txteseradi.Text) || string.IsNullOrWhiteSpace(txteserurl.Text))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurun ve bir kayıt seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Müzik SET eser_adı = @ad, eser_url = @url WHERE eser_id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txteseradi.Text);
                        cmd.Parameters.AddWithValue("@url", txteserurl.Text);
                        cmd.Parameters.AddWithValue("@id", selectedEserId);
                        cmd.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("Eser başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMuzikData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("eser_id") == null) return;

            selectedEserId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("eser_id"));
            txteseradi.Text = gridView1.GetFocusedRowCellValue("eser_adı").ToString();
            txteserurl.Text = gridView1.GetFocusedRowCellValue("eser_url").ToString();

            webView1.Source = new Uri(txteserurl.Text);
        }
    }
}
