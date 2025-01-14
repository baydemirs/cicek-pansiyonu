namespace cicek_pansiyonu
{
    partial class Form_sifreunuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.BtnBul = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCevap = new DevExpress.XtraEditors.TextEdit();
            this.BtnKontroEt = new DevExpress.XtraEditors.SimpleButton();
            this.TxtParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtParola2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.ParolaDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::cicek_pansiyonu.Properties.Resources.sifremiunuttum;
            this.pictureEdit1.Location = new System.Drawing.Point(326, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(412, 199);
            this.pictureEdit1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(158, 227);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 36);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "🔑 Kullanıcı Adı:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(326, 219);
            this.TxtKullaniciAdi.Margin = new System.Windows.Forms.Padding(5);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(318, 42);
            this.TxtKullaniciAdi.TabIndex = 10;
            // 
            // BtnBul
            // 
            this.BtnBul.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnBul.Appearance.Options.UseForeColor = true;
            this.BtnBul.Location = new System.Drawing.Point(652, 219);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(86, 42);
            this.BtnBul.TabIndex = 11;
            this.BtnBul.Text = "🔍 Bul";
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 283);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(314, 36);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "🧩 Şifreyi Unuttum Seçeneğiniz:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Bir seçenek seçiniz...";
            this.comboBoxEdit1.Location = new System.Drawing.Point(326, 280);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Annenizin kızlık soyadı?",
            "",
            "İlkokul öğretmeninizin adı?",
            "",
            "En sevdiğiniz kitap?",
            "",
            "Doğduğunuz şehir?",
            "",
            "Evcil hayvanınızın adı?",
            "",
            "İlk aracınızın modeli?",
            "",
            "Babanızın doğum yılı?",
            "",
            "En yakın arkadaşınızın adı?",
            "",
            "En sevdiğiniz film?",
            "",
            "Çocukluk takma adınız?",
            "",
            "İlk işyerinizin adı?",
            "",
            "Lise mezuniyet yılınız?"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(412, 42);
            this.comboBoxEdit1.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(199, 344);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(121, 36);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "💬 Yanıtınız:";
            // 
            // TxtCevap
            // 
            this.TxtCevap.Location = new System.Drawing.Point(326, 338);
            this.TxtCevap.Name = "TxtCevap";
            this.TxtCevap.Size = new System.Drawing.Size(412, 42);
            this.TxtCevap.TabIndex = 14;
            // 
            // BtnKontroEt
            // 
            this.BtnKontroEt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnKontroEt.Appearance.Options.UseForeColor = true;
            this.BtnKontroEt.Location = new System.Drawing.Point(326, 398);
            this.BtnKontroEt.Name = "BtnKontroEt";
            this.BtnKontroEt.Size = new System.Drawing.Size(412, 42);
            this.BtnKontroEt.TabIndex = 16;
            this.BtnKontroEt.Text = "✅     Kontrol Et";
            this.BtnKontroEt.Click += new System.EventHandler(this.BtnKontroEt_Click);
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(326, 462);
            this.TxtParola.Margin = new System.Windows.Forms.Padding(6);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Properties.UseSystemPasswordChar = true;
            this.TxtParola.Size = new System.Drawing.Size(412, 42);
            this.TxtParola.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(165, 468);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(150, 36);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "🔒 Yeni Parola:";
            // 
            // TxtParola2
            // 
            this.TxtParola2.Location = new System.Drawing.Point(326, 516);
            this.TxtParola2.Margin = new System.Windows.Forms.Padding(6);
            this.TxtParola2.Name = "TxtParola2";
            this.TxtParola2.Properties.UseSystemPasswordChar = true;
            this.TxtParola2.Size = new System.Drawing.Size(318, 42);
            this.TxtParola2.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(86, 522);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(229, 36);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "🔒 Yeni Parola(Tekrar):";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.SpringGreen;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Location = new System.Drawing.Point(652, 516);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(30, 44, 30, 44);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(86, 42);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "👁️/🙈 ";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ParolaDegistir
            // 
            this.ParolaDegistir.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ParolaDegistir.Appearance.Options.UseForeColor = true;
            this.ParolaDegistir.Location = new System.Drawing.Point(326, 577);
            this.ParolaDegistir.Name = "ParolaDegistir";
            this.ParolaDegistir.Size = new System.Drawing.Size(412, 42);
            this.ParolaDegistir.TabIndex = 22;
            this.ParolaDegistir.Text = "🔄 Parolayı Değiştir";
            this.ParolaDegistir.Click += new System.EventHandler(this.ParolaDegistir_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 583);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(272, 36);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "🔙 Giriş Sayfasına Geri Dön";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // Form_sifreunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 655);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.ParolaDegistir);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.TxtParola2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.BtnKontroEt);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtCevap);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.sifremiunuttum;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_sifreunuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.Form_sifreunuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton BtnBul;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtCevap;
        private DevExpress.XtraEditors.SimpleButton BtnKontroEt;
        private DevExpress.XtraEditors.TextEdit TxtParola;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtParola2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton ParolaDegistir;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}