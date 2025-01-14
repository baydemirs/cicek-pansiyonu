using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_Ana : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Form_Ana_Load(object sender, EventArgs e)
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
           // labelControl17.Text = Form_admin_giris.KullaniciAdi;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Mevcut saati labelControl1'e yazdır
            labelControl1.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat formatı: Saat:Dakika:Saniye
        }
    }
}
