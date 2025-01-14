using DevExpress.XtraEditors;
using System;
using System.Data.SQLite; // SQLite için
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_musteri_ekle : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;

        private decimal odaFiyati = 0; // Seçilen odanın fiyatını tutmak için sınıf seviyesi değişken

        public Form_musteri_ekle()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Çıkış tarihi başlangıçta devre dışı
            DtpCikisTarihi.Enabled = false;
            DtpCikisTarihi.Value = DateTime.Today;

            // TxtUcret başlangıçta boş
            TxtUcret.Text = string.Empty;

            // Tarih değişikliklerinde ücret hesaplama
            DtpGirisTarihi.ValueChanged += DtpGirisTarihi_ValueChanged;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            // Çıkış tarihini aktif hale getir
            DtpCikisTarihi.Enabled = true;

            // Çıkış tarihinin minimum değerini giriş tarihine ayarla
            DtpCikisTarihi.MinDate = DtpGirisTarihi.Value;

            // Eğer mevcut çıkış tarihi, yeni giriş tarihinden önceyse, çıkış tarihini minimum değere ayarla
            if (DtpCikisTarihi.Value < DtpGirisTarihi.Value)
            {
                DtpCikisTarihi.Value = DtpGirisTarihi.Value;
            }

            // Ücreti yeniden hesapla
            HesaplaUcret();
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            // Ücreti tekrar hesapla
            HesaplaUcret();
        }

        private void HesaplaUcret()
        {
            // Gün farkını hesapla
            int gunFarki = (DtpCikisTarihi.Value - DtpGirisTarihi.Value).Days;

            // Gün farkı en az 1 olmalı
            if (gunFarki <= 0)
            {
                gunFarki = 1;
            }

            // Toplam ücreti hesapla
            decimal toplamUcret = gunFarki * odaFiyati;

            // Toplam gün ve ücreti göster
            label11.Text = $"Toplam Gün: {gunFarki}";
            TxtUcret.Text = toplamUcret.ToString("F2");


        }
        private void ValidateTarihKontrolu()
        {
            if (DtpCikisTarihi.Value <= DtpGirisTarihi.Value)
            {
                throw new Exception("Çıkış tarihi, giriş tarihinden büyük olmalıdır!");
            }
        }

        private bool IsTextOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }

        private bool IsValidTCKimlikNo(string tcKimlikNo)
        {
            if (tcKimlikNo.Length != 11 || !long.TryParse(tcKimlikNo, out _) || tcKimlikNo[0] == '0')
                return false;

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += int.Parse(tcKimlikNo[i].ToString());
            }

            return toplam % 10 == int.Parse(tcKimlikNo[10].ToString());
        }

        private void ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Txtadi.Text) || !IsTextOnly(Txtadi.Text))
                throw new Exception("Ad alanına sadece harf girişi yapılabilir.");

            if (string.IsNullOrWhiteSpace(TxtSoyadi.Text) || !IsTextOnly(TxtSoyadi.Text))
                throw new Exception("Soyad alanına sadece harf girişi yapılabilir.");

            if (string.IsNullOrEmpty(TxtKimlikNo.Text) || !IsValidTCKimlikNo(TxtKimlikNo.Text))
                throw new Exception("T.C. Kimlik Numarası geçersiz! 11 haneli ve rakamlardan oluşmalıdır.");
            if (string.IsNullOrWhiteSpace(TxtOdaNo.Text)) // TxtOdaNo kontrolü
            {
                // DevExpress XtraMessageBox ile uyarı göster
                DevExpress.XtraEditors.XtraMessageBox.Show(
                    "Oda seçmediniz!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
        private void BtnOda101_Click(object sender, EventArgs e) => LoadOdaBilgileri("101");
        private void BtnOda102_Click(object sender, EventArgs e) => LoadOdaBilgileri("102");
        private void BtnOda103_Click(object sender, EventArgs e) => LoadOdaBilgileri("103");
        private void BtnOda201_Click(object sender, EventArgs e) => LoadOdaBilgileri("201");
        private void BtnOda202_Click(object sender, EventArgs e) => LoadOdaBilgileri("202");
        private void BtnOda203_Click(object sender, EventArgs e) => LoadOdaBilgileri("203");
        private void BtnOda301_Click(object sender, EventArgs e) => LoadOdaBilgileri("301");
        private void BtnOda302_Click(object sender, EventArgs e) => LoadOdaBilgileri("302");
        private void BtnOda303_Click(object sender, EventArgs e) => LoadOdaBilgileri("303");
        private void LoadOdaBilgileri(string odaNo)
        {
            try
            {
                // TxtOdaNo'ya gelen oda numarasını yazdır
                TxtOdaNo.Text = odaNo;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Odalar tablosundan oda bilgilerini al
                    string query = "SELECT fiyat FROM Odalar WHERE oda_adi = @OdaAdi";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OdaAdi", odaNo);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Oda fiyatını güncelle
                                odaFiyati = Convert.ToDecimal(reader["fiyat"]);
                                //  TxtUcret.Text = odaFiyati.ToString("F2");
                                TxtOdaUcret.Text = $"Seçilen Oda Fiyat: {odaFiyati:F2}";
                                HesaplaUcret();
                            }
                            else
                            {
                                XtraMessageBox.Show("Seçilen oda bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Oda bilgileri alınırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void InsertCustomerRecord(string ekSecenek)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Oda numarasına göre oda_id'yi al
                string odaIdQuery = "SELECT oda_id FROM Odalar WHERE oda_adi = @OdaAdi";
                int odaId = -1;

                using (SQLiteCommand odaCommand = new SQLiteCommand(odaIdQuery, connection))
                {
                    odaCommand.Parameters.AddWithValue("@OdaAdi", TxtOdaNo.Text);
                    var result = odaCommand.ExecuteScalar();

                    if (result != null)
                    {
                        odaId = Convert.ToInt32(result);
                    }
                    else
                    {
                        XtraMessageBox.Show("Seçilen oda bulunamadı. Kayıt yapılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Müşteri bilgilerini ekle
                string insertQuery = @"INSERT INTO Müşteriler 
                               (adı, soyadı, cinsiyet, mail, telefon, tc_kimlik_no, oda_id, ücret, giriş_tarihi, çıkış_tarihi, ek_secenek) 
                               VALUES 
                               (@Adı, @Soyadı, @Cinsiyet, @Mail, @Telefon, @TCKimlikNo, @OdaId, @Ücret, @GirişTarihi, @ÇıkışTarihi, @EkSecenek)";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Adı", Txtadi.Text);
                    insertCommand.Parameters.AddWithValue("@Soyadı", TxtSoyadi.Text);
                    insertCommand.Parameters.AddWithValue("@Cinsiyet", comboBoxEdit1.Text);
                    insertCommand.Parameters.AddWithValue("@Mail", TxtMail.Text);
                    insertCommand.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
                    insertCommand.Parameters.AddWithValue("@TCKimlikNo", TxtKimlikNo.Text);
                    insertCommand.Parameters.AddWithValue("@OdaId", odaId);
                    insertCommand.Parameters.AddWithValue("@Ücret", Convert.ToDecimal(TxtUcret.Text));
                    insertCommand.Parameters.AddWithValue("@GirişTarihi", DtpGirisTarihi.Value);
                    insertCommand.Parameters.AddWithValue("@ÇıkışTarihi", DtpCikisTarihi.Value);
                    insertCommand.Parameters.AddWithValue("@EkSecenek", ekSecenek);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }


        private void UpdateOdaDurumu()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Odanın doluluk durumunu güncelle
                string query = "UPDATE Odalar SET doluluk_durumu = 1 WHERE oda_adi = @OdaAdi";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OdaAdi", TxtOdaNo.Text);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Tarih kontrolü Çıkış tarihi giriş tarihinden büyük olamaz kontrolü
                ValidateTarihKontrolu();

                // Girişleri doğrula
                ValidateInputs();

                // Ekstra battaniye sorusu
                DialogResult result = XtraMessageBox.Show("Ekstra battaniye ister misiniz?", "Ekstra Seçenek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string ekSecenek = result == DialogResult.Yes ? "Evet" : "Hayır";

                // Müşteri kaydet
                InsertCustomerRecord(ekSecenek);

                // Oda durumunu güncelle
                UpdateOdaDurumu();

                // Başarı mesajı
                XtraMessageBox.Show("Müşteri başarıyla eklendi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOdaDurumu();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_musteri_ekle_Load(object sender, EventArgs e)
        {
            string connectionString = ProgramDatabaseConfig.ConnectionString;
            string query = "SELECT oda_id, oda_adi, doluluk_durumu FROM Odalar";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int odaId = reader.GetInt32(0);
                        string odaAdi = reader.GetString(1);
                        int dolulukDurumu = reader.GetInt32(2);

                        // Butonu bul
                        Button btnOda = this.Controls.Find($"BtnOda{odaAdi}", true).FirstOrDefault() as Button;
                        if (btnOda != null)
                        {
                            if (dolulukDurumu == 1) // Doluysa
                            {
                                btnOda.BackColor = Color.LightCoral;
                                btnOda.Enabled = false; // Buton devre dışı kalsın
                            }
                            else // Boşsa
                            {
                                btnOda.BackColor = Color.FromArgb(128, 255, 128); // Yeşil renk (128, 255, 128)
                                btnOda.Enabled = true; // Buton aktif bırak
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                }
            }
        }
    }
}

        
   
