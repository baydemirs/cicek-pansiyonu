using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite; // SQLite için kütüphane
using System.Security.Cryptography; // Hashleme için
using System.Text; // Hash formatı için
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_kayit : DevExpress.XtraEditors.XtraForm
    {
        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        public Form_kayit()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Parola gizleme/gösterme işlemi
            TxtParola.Properties.UseSystemPasswordChar = !TxtParola.Properties.UseSystemPasswordChar;

            // Butonun metnini güncelle (opsiyonel)
            if (TxtParola.Properties.UseSystemPasswordChar)
            {
                simpleButton2.Text = "👁️ Göster";
            }
            else
            {
                simpleButton2.Text = "🙈 Gizle";
            }
        }

        private bool _capsLockWarningShown = false; // Caps Lock durumu için kontrol değişkeni
        private void TxtParola_KeyDown(object sender, KeyEventArgs e)
        {
            // Caps Lock kontrolü
            bool capsLockActive = Control.IsKeyLocked(Keys.CapsLock);

            if (capsLockActive && !_capsLockWarningShown)
            {
                // Caps Lock açıkken sadece bir kere uyarı ver
                XtraMessageBox.Show("Caps Lock tuşu açık! Lütfen dikkat edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _capsLockWarningShown = true;
            }
            else if (!capsLockActive)
            {
                // Caps Lock kapatıldığında durumu sıfırla
                _capsLockWarningShown = false;
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            // Form_admin_giris formunu başlat
            Form_admin_giris formAdminGiris = new Form_admin_giris();

            // Yeni formu göster
            formAdminGiris.Show();

            // Mevcut formu kapat
            this.Close();
        }

        private void Form_kayit_Load(object sender, EventArgs e)
        {

        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(TxtKadi.Text) ||
                string.IsNullOrWhiteSpace(TxtParola.Text) ||
                string.IsNullOrWhiteSpace(comboBoxEdit1.Text) ||
                string.IsNullOrWhiteSpace(TxtCevap.Text))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı adı benzersiz mi kontrolü
                    string checkQuery = "SELECT COUNT(*) FROM Kullanıcılar WHERE kullanıcı_adı = @Kullaniciadi";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Kullaniciadi", TxtKadi.Text);

                        long count = (long)checkCommand.ExecuteScalar(); // Kullanıcı adı sayısını al
                        if (count > 0)
                        {
                            XtraMessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen başka bir kullanıcı adı deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // İşlemi durdur
                        }
                    }

                    // Parolayı hashle
                    string hashedPassword = HashPassword(TxtParola.Text);

                    // Kullanıcılar tablosuna veri ekleme
                    string insertQuery = "INSERT INTO Kullanıcılar (kullanıcı_adı, parola, sifre_soru, sifre_cevap, yetki) VALUES (@kullanıcı_adı, @parola, @sifre_soru, @sifre_cevap, @yetki)";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        // Parametre değerlerini atama
                        insertCommand.Parameters.AddWithValue("@kullanıcı_adı", TxtKadi.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@parola", hashedPassword); // Hashlenmiş parola
                        insertCommand.Parameters.AddWithValue("@sifre_soru", comboBoxEdit1.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@sifre_cevap", TxtCevap.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@yetki", "admin"); // Yetki varsayılan olarak "admin"

                        // Sorguyu çalıştır
                        int result = insertCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            XtraMessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Kayıt yapılamadı. Tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Parolayı SHA-256 ile hashlemek için bir yöntem
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Hash'i hexadecimal formatta döndür
                }
                return builder.ToString();
            }
        }
    }
}
