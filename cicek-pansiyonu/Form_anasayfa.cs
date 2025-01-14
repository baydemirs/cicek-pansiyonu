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

namespace cicek_pansiyonu
{
    public partial class Form_anasayfa : DevExpress.XtraEditors.XtraForm
    {
        private Timer timer; // Timer nesnesi
        public Form_anasayfa()
        {
            InitializeComponent();
        }

        private void Form_anasayfa_Load(object sender, EventArgs e)
        {
            // Mevcut saat bilgisini labelControl1'e yazdır
            labelControl1.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat: Dakika: Saniye

            // Mevcut tarih bilgisini labelControl16'ya yazdır
            labelControl16.Text = DateTime.Now.ToString("dd.MM.yyyy"); // Gün.Ay.Yıl
                                                                       // Timer nesnesini başlat
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye (1000 milisaniye)
            timer.Tick += Timer_Tick; // Timer_Tick olayına bağlan
            timer.Start(); // Timer'ı başlat

            // Giriş yapan kullanıcı adını labelControl17'ye yazdır
            labelControl17.Text = Form_admin_giris.KullaniciAdi;
        }
        // Timer Tick Olayı: Her saniye çalışır
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Mevcut saati labelControl1'e yazdır
            labelControl1.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat formatı: Saat:Dakika:Saniye
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Form_Odalar odalarForm = new Form_Odalar();
            this.Hide();
            odalarForm.FormClosed += (s, args) => this.Show();
            odalarForm.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form_musteri_ekle musteriEkleForm = new Form_musteri_ekle();
            this.Hide(); // Ana sayfayı gizle
            musteriEkleForm.FormClosed += (s, args) => this.Show(); // Form kapanınca ana sayfayı göster
            musteriEkleForm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Form_musteriler musterilerForm = new Form_musteriler();
            this.Hide();
            musterilerForm.FormClosed += (s, args) => this.Show();
            musterilerForm.Show();
        }

        private void BtnPersonelMaas_Click(object sender, EventArgs e)
        {
            Form_Personel personelForm = new Form_Personel();
            this.Hide();
            personelForm.FormClosed += (s, args) => this.Show();
            personelForm.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            Form_stok stokForm = new Form_stok();
            this.Hide();
            stokForm.FormClosed += (s, args) => this.Show();
            stokForm.Show();

        }

        private void BtnMüsteriMesaj_Click(object sender, EventArgs e)
        {
            Form_musteri_mesaj msjForm = new Form_musteri_mesaj();
            this.Hide();
            msjForm.FormClosed += (s, args) => this.Show();
            msjForm.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            Form_muzik muzikForm = new Form_muzik();
            this.Hide();
            muzikForm.FormClosed += (s, args) => this.Show();
            muzikForm.Show();
        }
    }
}