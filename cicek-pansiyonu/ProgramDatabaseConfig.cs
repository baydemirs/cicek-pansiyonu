using DevExpress.XtraEditors;
using System.Data.SQLite;
using System.Windows.Forms;
using System;


namespace cicek_pansiyonu
{
    internal static class ProgramDatabaseConfig
    {
        // Veritabanı yolunu içeren bağlantı dizesi (connection string)
        public static string ConnectionString { get; private set; }

        /// Kullanıcının bir veritabanı dosyası seçmesini sağlar ve bağlantıyı test eder.
        public static bool SelectAndInitializeDatabase()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Database Files (*.db)|*.db|All Files (*.*)|*.*";
                openFileDialog.Title = "Veritabanı Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string databasePath = openFileDialog.FileName;

                    // Bağlantı dizesini ayarla
                    SetConnectionString(databasePath);

                    // Bağlantıyı test et
                    if (TestConnection())
                    {
                        XtraMessageBox.Show("Veritabanı bağlantısı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Veritabanı bağlantısı kurulamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Herhangi bir veritabanı dosyası seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        /// Veritabanı dosya yoluna göre bağlantı dizesini ayarlar.
        private static void SetConnectionString(string databasePath)
        {
            if (string.IsNullOrEmpty(databasePath))
                throw new ArgumentException("Veritabanı yolu boş olamaz.", nameof(databasePath));

            ConnectionString = $"Data Source={databasePath};Version=3;";
        }

        /// Veritabanı bağlantısını test eder.
        // Bağlantı başarılıysa true, aksi takdirde false döner.
        public static bool TestConnection()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    connection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class FormlararasıString
    {
        public void UseDatabaseConnection()
        {
            // ProgramDatabaseConfig.ConnectionString üzerinden bağlantı alınır
            string connectionString = ProgramDatabaseConfig.ConnectionString;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // Veritabanı işlemleri burada yapılır
                connection.Close();
            }
        }
    }
}