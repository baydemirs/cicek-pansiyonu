using DevExpress.XtraEditors;
using System;
using System.Data.SQLite; // SQLite için
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_Odalar : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;

        public Form_Odalar()
        {
            InitializeComponent();
        }

        // Oda numarasına göre odanın bilgilerini yükleyen metot
        private void LoadOdaBilgileri(string odaNo)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Odaların oda_adi ve fiyat bilgilerini al
                    string query = "SELECT oda_adi, fiyat FROM Odalar WHERE oda_adi = @OdaAdi";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OdaAdi", odaNo);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TxtOdaAdi.Text = reader["oda_adi"].ToString(); // Oda adını al
                                TxtOdaFiyat.Text = reader["fiyat"].ToString(); // Fiyatı al
                            }
                            else
                            {
                                XtraMessageBox.Show("Oda bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Oda fiyatını güncelleyen metot
        private void OdaFiyatGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtOdaAdi.Text) || string.IsNullOrWhiteSpace(TxtOdaFiyat.Text))
            {
                XtraMessageBox.Show("Lütfen oda numarası ve fiyat bilgilerini doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Fiyat güncelleme sorgusu
                    string query = "UPDATE Odalar SET fiyat = @Fiyat WHERE oda_adi = @OdaAdi";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(TxtOdaFiyat.Text));
                        command.Parameters.AddWithValue("@OdaAdi", TxtOdaAdi.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            XtraMessageBox.Show("Oda fiyatı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Oda fiyatı güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Oda butonlarına tıklandığında ilgili oda bilgilerini yükle
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("101");
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("102");
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("103");
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("201");
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("202");
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("203");
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("301");
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("302");
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            LoadOdaBilgileri("303");
        }
    }
}
