using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // SQLite kütüphanesi

namespace cicek_pansiyonu
{
    public partial class Form_stok : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        private int selectedId = -1; // Seçilen stok veya fatura ID'si
        private string selectedTable = ""; // Hangi tablonun seçildiğini belirlemek için

        public Form_stok()
        {
            InitializeComponent();
        }

        private void Form_stok_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    // Stok tablosunu yükle
                    string queryStok = "SELECT * FROM Stok";
                    SQLiteDataAdapter adapterStok = new SQLiteDataAdapter(queryStok, connection);
                    DataTable dataTableStok = new DataTable();
                    adapterStok.Fill(dataTableStok);
                    gridControl1.DataSource = dataTableStok;

                    // Faturalar tablosunu yükle
                    string queryFaturalar = "SELECT * FROM Faturalar";
                    SQLiteDataAdapter adapterFaturalar = new SQLiteDataAdapter(queryFaturalar, connection);
                    DataTable dataTableFaturalar = new DataTable();
                    adapterFaturalar.Fill(dataTableFaturalar);
                    gridControl2.DataSource = dataTableFaturalar;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            selectedTable = "Stok";
            if (gridView1.GetFocusedRowCellValue("stok_id") != null)
            {
                selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("stok_id"));
                UFaturaAdı.Text = gridView1.GetFocusedRowCellValue("stok_adı")?.ToString();
                UFaturaTürü.Text = gridView1.GetFocusedRowCellValue("stok_türü")?.ToString();
                UTxtFaturaFiyat.Text = gridView1.GetFocusedRowCellValue("fiyat")?.ToString();
                UDtp.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("stok_tarihi")?.ToString());
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            selectedTable = "Faturalar";
            if (gridView2.GetFocusedRowCellValue("fatura_id") != null)
            {
                selectedId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("fatura_id"));
                UFaturaAdı.Text = gridView2.GetFocusedRowCellValue("fatura_adı")?.ToString();
                UFaturaTürü.Text = gridView2.GetFocusedRowCellValue("fatura_türü")?.ToString();
                UTxtFaturaFiyat.Text = gridView2.GetFocusedRowCellValue("fiyat")?.ToString();
                UDtp.Value = DateTime.Parse(gridView2.GetFocusedRowCellValue("fatura_tarihi")?.ToString());
            }
        }

        private void BtnStokEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtStokAdi.Text) || string.IsNullOrWhiteSpace(TxtStokTürü.Text) ||
               string.IsNullOrWhiteSpace(TxtStokFiyat.Text) || DtpStokTarihi.Value == null)
            {
                XtraMessageBox.Show("Tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TxtStokFiyat.Text, out decimal fiyat))
            {
                XtraMessageBox.Show("Fiyat sadece sayısal olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = "INSERT INTO Stok (stok_adı, stok_türü, fiyat, stok_tarihi) VALUES (@ad, @tur, @fiyat, @tarih)";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", TxtStokAdi.Text);
                    command.Parameters.AddWithValue("@tur", TxtStokTürü.Text);
                    command.Parameters.AddWithValue("@fiyat", fiyat);
                    command.Parameters.AddWithValue("@tarih", DtpStokTarihi.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    XtraMessageBox.Show("Stok başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFaturaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFaturaAdı.Text) || string.IsNullOrWhiteSpace(TxtFaturaTürü.Text) ||
                string.IsNullOrWhiteSpace(TxtFaturaFiyat.Text) || DtpFaturaTarihi.Value == null)
            {
                XtraMessageBox.Show("Tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TxtFaturaFiyat.Text, out decimal fiyat))
            {
                XtraMessageBox.Show("Fiyat sadece sayısal olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = "INSERT INTO Faturalar (fatura_adı, fatura_türü, fiyat, fatura_tarihi) VALUES (@ad, @tur, @fiyat, @tarih)";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", TxtFaturaAdı.Text);
                    command.Parameters.AddWithValue("@tur", TxtFaturaTürü.Text);
                    command.Parameters.AddWithValue("@fiyat", fiyat);
                    command.Parameters.AddWithValue("@tarih", DtpFaturaTarihi.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    XtraMessageBox.Show("Fatura başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usil_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                XtraMessageBox.Show("Lütfen silinecek bir öğe seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        string query = $"DELETE FROM {selectedTable} WHERE {(selectedTable == "Stok" ? "stok_id" : "fatura_id")} = @id";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@id", selectedId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        XtraMessageBox.Show("Silme işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Uguncelle_Click(object sender, EventArgs e)
        {
            if (selectedId == -1 || string.IsNullOrWhiteSpace(UFaturaAdı.Text) || string.IsNullOrWhiteSpace(UFaturaTürü.Text) || string.IsNullOrWhiteSpace(UTxtFaturaFiyat.Text))
            {
                XtraMessageBox.Show("Tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(UTxtFaturaFiyat.Text, out decimal fiyat))
            {
                XtraMessageBox.Show("Fiyat sadece sayısal olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = $@"
                        UPDATE {selectedTable}
                        SET {(selectedTable == "Stok" ? "stok_adı = @ad, stok_türü = @tur, fiyat = @fiyat, stok_tarihi = @tarih" :
                                                     "fatura_adı = @ad, fatura_türü = @tur, fiyat = @fiyat, fatura_tarihi = @tarih")}
                        WHERE {(selectedTable == "Stok" ? "stok_id" : "fatura_id")} = @id";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", UFaturaAdı.Text);
                    command.Parameters.AddWithValue("@tur", UFaturaTürü.Text);
                    command.Parameters.AddWithValue("@fiyat", fiyat);
                    command.Parameters.AddWithValue("@tarih", UDtp.Value);
                    command.Parameters.AddWithValue("@id", selectedId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    XtraMessageBox.Show("Güncelleme işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

