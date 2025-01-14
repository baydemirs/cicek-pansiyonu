using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite; // SQLite için kütüphane
using System.Security.Cryptography; // Hash kontrolü için
using System.Text; // Hash string formatı için
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_admin_giris : DevExpress.XtraEditors.XtraForm
    {

        // SQLite veritabanı bağlantı dizesi
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;

      
        public Form_admin_giris()
        {
            InitializeComponent();
            this.KeyPreview = true; // Tuş olaylarını formda yakalamak için etkinleştir
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Parola gizleme/gösterme işlemi
            TxtParola.Properties.UseSystemPasswordChar = !TxtParola.Properties.UseSystemPasswordChar;

            if (TxtParola.Properties.UseSystemPasswordChar)
            {
                simpleButton1.Text = "👁️ Göster";
            }
            else
            {
                simpleButton1.Text = "🙈 Gizle";
            }
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(TxtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(TxtParola.Text))
            {
                XtraMessageBox.Show("Kullanıcı Adı ve Parola alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı adı ve hashlenmiş parola eşleşmesini kontrol et
                    string query = "SELECT COUNT(*) FROM Kullanıcılar WHERE kullanıcı_adı = @Kullaniciadi AND parola = @Parola";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Kullanıcıdan alınan şifreyi hashle
                        string hashedPassword = HashPassword(TxtParola.Text);
                        command.Parameters.AddWithValue("@Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                        command.Parameters.AddWithValue("@Parola", hashedPassword);

                        long result = (long)command.ExecuteScalar();

                        if (result > 0)
                        {
                            XtraMessageBox.Show("Giriş Başarılı. Ana sayfaya yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KullaniciAdi = TxtKullaniciAdi.Text;

                            Form_anasayfa formAnasayfa = new Form_anasayfa();
                            formAnasayfa.Show();
                            this.Hide();
                        }
                        else
                        {
                            XtraMessageBox.Show("Kullanıcı Adı veya Parola hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            Form_kayit formKayit = new Form_kayit();
            this.Hide();
            formKayit.ShowDialog();
            this.Show();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            Form_sifreunuttum formSifremiUnuttum = new Form_sifreunuttum();
            this.Hide();
            formSifremiUnuttum.ShowDialog();
            this.Show();
        }

        // SHA-256 ile şifreyi hashleyen metod
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

        public static string KullaniciAdi { get; set; } //parametre gönderme
        private bool _capsLockWarningShown = false; // Uyarının tekrarını önlemek için kontrol değişkeni
        private void TxtParola_KeyDown(object sender, KeyEventArgs e)
        {
            bool capsLockActive = Control.IsKeyLocked(Keys.CapsLock); // Caps Lock durumunu kontrol et

            if (capsLockActive && !_capsLockWarningShown)
            {
                // Caps Lock açıkken bir kez uyarı mesaj kutusu göster
                XtraMessageBox.Show("Caps Lock tuşu açık! Parolanız büyük harf ile yazılıyor olabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _capsLockWarningShown = true; // Uyarı gösterildi
            }
            else if (!capsLockActive)
            {
                // Caps Lock kapatıldığında kontrol değişkenini sıfırla
                _capsLockWarningShown = false;
            }
        }

        private void Form_admin_giris_Load(object sender, EventArgs e)
        {

        }

        private void Form_admin_giris_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında BtnGirisYap butonunu çalıştır
            if (e.KeyCode == Keys.Enter)
            {
                BtnGirisYap.PerformClick(); // Butonun Click olayını tetikle
            }
        }
    }
}
