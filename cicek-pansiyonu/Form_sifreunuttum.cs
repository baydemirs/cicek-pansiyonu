using DevExpress.XtraEditors;
using System;
using System.Data.SQLite; // SQLite için kütüphane
using System.Security.Cryptography; // Hashleme için
using System.Text; // Hash string formatı için
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_sifreunuttum : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        private int id_kullanici; // Kullanıcı ID'sini tutmak için

        public Form_sifreunuttum()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Parola gizleme/gösterme işlemi
            TxtParola.Properties.UseSystemPasswordChar = !TxtParola.Properties.UseSystemPasswordChar;
            TxtParola2.Properties.UseSystemPasswordChar = !TxtParola2.Properties.UseSystemPasswordChar;

            // Butonun metnini güncelle (opsiyonel)
            if (TxtParola.Properties.UseSystemPasswordChar && TxtParola2.Properties.UseSystemPasswordChar)
            {
                simpleButton3.Text = "👁️";
            }
            else
            {
                simpleButton3.Text = "🙈";
            }
        }

        private void Form_sifreunuttum_Load(object sender, EventArgs e)
        {
            TxtParola.Properties.ReadOnly = true;
            TxtParola2.Properties.ReadOnly = true;
            comboBoxEdit1.Properties.ReadOnly = true;
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtKullaniciAdi.Text))
            {
                XtraMessageBox.Show("Lütfen Kullanıcı Adı alanını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT kullanıcı_id, sifre_soru 
                                     FROM Kullanıcılar 
                                     WHERE kullanıcı_adı = @Kullaniciadi";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Kullaniciadi", TxtKullaniciAdi.Text);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id_kullanici = Convert.ToInt32(reader["kullanıcı_id"]);
                                comboBoxEdit1.Text = reader["sifre_soru"].ToString();
                                comboBoxEdit1.Properties.ReadOnly = true;

                                XtraMessageBox.Show("Bilgiler bulundu ve yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                XtraMessageBox.Show("Kullanıcı adı bulunamadı. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnKontroEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCevap.Text))
            {
                XtraMessageBox.Show("Lütfen bir yanıt giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT kullanıcı_id FROM Kullanıcılar WHERE sifre_cevap = @Yanit AND kullanıcı_id = @KullaniciID";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Yanit", TxtCevap.Text.Trim());
                        command.Parameters.AddWithValue("@KullaniciID", id_kullanici);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            TxtParola.Properties.ReadOnly = false;
                            TxtParola2.Properties.ReadOnly = false;

                            XtraMessageBox.Show("Yanıt doğru, parola alanlarını doldurabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Hatalı yanıt girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParolaDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtParola.Text) || string.IsNullOrWhiteSpace(TxtParola2.Text))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtParola.Text != TxtParola2.Text)
            {
                XtraMessageBox.Show("Parolalar eşleşmiyor. Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE Kullanıcılar SET parola = @Parola WHERE kullanıcı_id = @id_kullanici";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Parolayı hashleyerek kaydet
                        string hashedPassword = HashPassword(TxtParola.Text);
                        command.Parameters.AddWithValue("@Parola", hashedPassword);
                        command.Parameters.AddWithValue("@id_kullanici", id_kullanici);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            XtraMessageBox.Show("Parola başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtParola.Text = string.Empty;
                            TxtParola2.Text = string.Empty;
                            TxtKullaniciAdi.Text = string.Empty;
                            comboBoxEdit1.Text = string.Empty;
                            TxtCevap.Text = string.Empty;

                            TxtParola.Properties.ReadOnly = true;
                            TxtParola2.Properties.ReadOnly = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("Parola güncellenemedi. Tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {
            Form_admin_giris formAdminGiris = new Form_admin_giris();
            formAdminGiris.Show();
            this.Close();
        }
    }
}
