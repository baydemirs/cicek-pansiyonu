using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite; // SQLite kütüphanesi
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_musteri_mesaj : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        private int selectedMusteriId = -1;

        public Form_musteri_mesaj()
        {
            InitializeComponent();
        }

        private void Form_musteri_mesaj_Load(object sender, EventArgs e)
        {
            LoadMusteriMesajlari();
        }

        private void LoadMusteriMesajlari()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = @"
                        SELECT mm.mesaj_id, m.adı, m.telefon, m.tc_kimlik_no, mm.mesaj
                        FROM MüşteriMesajları mm
                        INNER JOIN Müşteriler m ON mm.müşteri_id = m.müşteri_id";

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    gridControl1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MüsteriyiBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = @"
                        SELECT * 
                        FROM Müşteriler 
                        WHERE adı LIKE @ad OR telefon LIKE @telefon OR tc_kimlik_no LIKE @tc";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", "%" + TxtBulAdi.Text + "%");
                    command.Parameters.AddWithValue("@telefon", "%" + TxtBulTel.Text + "%");
                    command.Parameters.AddWithValue("@tc", "%" + TxtBulTC.Text + "%");

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    gridControl1.DataSource = dataTable;

                    if (dataTable.Rows.Count > 0)
                    {
                        TxtBuldu.Text = $"{dataTable.Rows[0]["adı"]} {dataTable.Rows[0]["soyadı"]}";
                    }
                    else
                    {
                        XtraMessageBox.Show("Müşteri bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("adı") != null)
            {
                TxtBulAdi.Text = gridView1.GetFocusedRowCellValue("adı").ToString();
                TxtBulTel.Text = gridView1.GetFocusedRowCellValue("telefon").ToString();
                TxtBulTC.Text = gridView1.GetFocusedRowCellValue("tc_kimlik_no").ToString();
                if (gridView1.GetFocusedRowCellValue("mesaj") != null &&
                !string.IsNullOrWhiteSpace(gridView1.GetFocusedRowCellValue("mesaj").ToString()))
                {
                    memoEdit1.Text = gridView1.GetFocusedRowCellValue("mesaj").ToString();
                }
                else
                {
                    memoEdit1.Text = string.Empty; // Boş değer atar
                }

                // Seçili müşteri_id'yi saklama
                selectedMusteriId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("müşteri_id"));
            }
        }

        private void MsjEkle_Click(object sender, EventArgs e)
        {
            if (selectedMusteriId == -1 || string.IsNullOrWhiteSpace(memoEdit1.Text))
            {
                XtraMessageBox.Show("Lütfen bir müşteri seçin ve mesaj girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO MüşteriMesajları (müşteri_id, mesaj)
                        VALUES (@müşteri_id, @mesaj)";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@müşteri_id", selectedMusteriId);
                    command.Parameters.AddWithValue("@mesaj", memoEdit1.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    XtraMessageBox.Show("Mesaj başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMusteriMesajlari();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MsjGüncelle_Click(object sender, EventArgs e)
        {
            if (selectedMusteriId == -1 || string.IsNullOrWhiteSpace(memoEdit1.Text))
            {
                XtraMessageBox.Show("Lütfen bir müşteri seçin ve mesaj girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = @"
                        UPDATE MüşteriMesajları
                        SET mesaj = @mesaj
                        WHERE mesaj_id = @mesaj_id";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@mesaj", memoEdit1.Text);
                    command.Parameters.AddWithValue("@mesaj_id", gridView1.GetFocusedRowCellValue("mesaj_id"));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    XtraMessageBox.Show("Mesaj başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMusteriMesajlari();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Msjsil_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("mesaj_id") == null)
            {
                XtraMessageBox.Show("Lütfen silinecek bir mesaj seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show(
                "Bu mesajı silmek istediğinize emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        string query = @"
                            DELETE FROM MüşteriMesajları
                            WHERE mesaj_id = @mesaj_id";

                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@mesaj_id", gridView1.GetFocusedRowCellValue("mesaj_id"));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        XtraMessageBox.Show("Mesaj başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMusteriMesajlari();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
