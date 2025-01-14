using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_Personel : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        private int selectedPersonelId = -1; // Seçili personelin ID'si

        public Form_Personel()
        {
            InitializeComponent();
        }

        private void Form_Personel_Load(object sender, EventArgs e)
        {
            // Çıkış tarihi başlangıçta devre dışı bırakılır
            DtpCikisTarihi.Enabled = false;

            // GridControl'e veritabanındaki personel verilerini yükle
            LoadPersonnelData();
        }

        private void LoadPersonnelData()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    var query = "SELECT * FROM Personel";
                    var adapter = new SQLiteDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridControl1.DataSource = dataTable;
                    gridView1.PopulateColumns();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("personel_id") != null)
                {
                    selectedPersonelId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("personel_id"));
                    TxtPersonelAdi.Text = gridView1.GetFocusedRowCellValue("adı")?.ToString();
                    TxtCalismaSaat.Text = gridView1.GetFocusedRowCellValue("günlük_çalışma_saati")?.ToString();
                    TxtSaatFiyat.Text = gridView1.GetFocusedRowCellValue("saat_başı_ücret")?.ToString();
                    DtpGirisTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("giriş_tarihi"));

                    var cikisTarihi = gridView1.GetFocusedRowCellValue("çıkış_tarihi");
                    if (cikisTarihi != DBNull.Value && cikisTarihi != null)
                    {
                        DtpCikisTarihi.Value = Convert.ToDateTime(cikisTarihi);
                        DtpCikisTarihi.Enabled = true;
                    }
                    else
                    {
                        DtpCikisTarihi.Enabled = false;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen geçerli bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPersonelBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    var query = @"SELECT * FROM Personel WHERE (@adı IS NULL OR adı LIKE @adı)";
                    var command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@adı", string.IsNullOrWhiteSpace(TxtPersonelAdi.Text) ? (object)DBNull.Value : $"%{TxtPersonelAdi.Text}%");

                    var adapter = new SQLiteDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridControl1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Aradığınız kritere uygun personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Personel aranırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DtpCikisTarihi.MinDate = DtpGirisTarihi.Value;
                DtpCikisTarihi.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TxtPersonelAdi.Text, @"^[a-zA-ZğüşöçİĞÜŞÖÇ ]+$"))
            {
                XtraMessageBox.Show("Personel adı yalnızca harflerden oluşmalıdır.");
                return;
            }

            if (!decimal.TryParse(TxtCalismaSaat.Text, out _) || !decimal.TryParse(TxtSaatFiyat.Text, out _))
            {
                XtraMessageBox.Show("Çalışma saati ve saat ücreti yalnızca rakamlardan oluşmalıdır.");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    var command = new SQLiteCommand("INSERT INTO Personel (adı, günlük_çalışma_saati, saat_başı_ücret, giriş_tarihi, çıkış_tarihi) VALUES (@adı, @çalışma, @ücret, @giriş, @çıkış)", connection);
                    command.Parameters.AddWithValue("@adı", TxtPersonelAdi.Text);
                    command.Parameters.AddWithValue("@çalışma", Convert.ToDecimal(TxtCalismaSaat.Text));
                    command.Parameters.AddWithValue("@ücret", Convert.ToDecimal(TxtSaatFiyat.Text));
                    command.Parameters.AddWithValue("@giriş", DtpGirisTarihi.Value);
                    command.Parameters.AddWithValue("@çıkış", DtpCikisTarihi.Enabled ? (object)DtpCikisTarihi.Value : DBNull.Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                XtraMessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersonnelData();
                ClearForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Personel eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            if (selectedPersonelId == -1)
            {
                XtraMessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = XtraMessageBox.Show("Seçilen personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        var command = new SQLiteCommand("DELETE FROM Personel WHERE personel_id = @id", connection);
                        command.Parameters.AddWithValue("@id", selectedPersonelId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    XtraMessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPersonnelData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Personel silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            TxtPersonelAdi.Text = "";
            TxtCalismaSaat.Text = "";
            TxtSaatFiyat.Text = "";
            DtpGirisTarihi.Value = DateTime.Now;
            DtpCikisTarihi.Value = DateTime.Now;
            DtpCikisTarihi.Enabled = false;
            selectedPersonelId = -1;
        }

        private void BtnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedPersonelId == -1)
            {
                XtraMessageBox.Show("Lütfen güncellemek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           /* if (!Regex.IsMatch(TxtPersonelAdi.Text.Trim(), @"^[a-zA-ZğüşöçİĞÜŞÖÇ ]+$") || string.IsNullOrWhiteSpace(TxtPersonelAdi.Text))
            {
                XtraMessageBox.Show("Personel adı yalnızca harflerden ve boşluklardan oluşmalıdır.");
                return;
            }*/


            if (!decimal.TryParse(TxtCalismaSaat.Text, out _) || !decimal.TryParse(TxtSaatFiyat.Text, out _))
            {
                XtraMessageBox.Show("Çalışma saati ve saat ücreti yalnızca rakamlardan oluşmalıdır.");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    var command = new SQLiteCommand(
                        "UPDATE Personel SET adı = @adı, günlük_çalışma_saati = @çalışma, saat_başı_ücret = @ücret, giriş_tarihi = @giriş, çıkış_tarihi = @çıkış WHERE personel_id = @id",
                        connection
                    );
                    command.Parameters.AddWithValue("@adı", TxtPersonelAdi.Text);
                    command.Parameters.AddWithValue("@çalışma", Convert.ToDecimal(TxtCalismaSaat.Text));
                    command.Parameters.AddWithValue("@ücret", Convert.ToDecimal(TxtSaatFiyat.Text));
                    command.Parameters.AddWithValue("@giriş", DtpGirisTarihi.Value);
                    command.Parameters.AddWithValue("@çıkış", DtpCikisTarihi.Enabled ? (object)DtpCikisTarihi.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@id", selectedPersonelId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                XtraMessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersonnelData();
                ClearForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Personel güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
