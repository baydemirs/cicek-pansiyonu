using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_AStarter : DevExpress.XtraEditors.XtraForm
    {
        public Form_AStarter()
        {
            InitializeComponent();
            this.labelTelif.Text = "Tüm hakları saklıdır. © 2024-" + DateTime.Now.Year.ToString();
        }

        private async void Form_AStarter_Load(object sender, EventArgs e)
        {
            try
            {
                // 3 saniye bekle
                await Task.Delay(2000);

                // Veritabanı yapılandırmasını kontrol et
                if (ProgramDatabaseConfig.SelectAndInitializeDatabase())
                {
                    // Giriş formunu aç
                    Form_admin_giris giris = new Form_admin_giris();
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    // Veritabanı yapılandırması başarısızsa çık
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster ve çık
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
