namespace cicek_pansiyonu
{
    partial class Form_admin_giris
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtParola = new DevExpress.XtraEditors.TextEdit();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(247, 462);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(30, 44, 30, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(325, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Parolayı 👁️ Göster/🙈 Gizle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(74, 361);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 36);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "🔑 Kullanıcı Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(130, 414);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 36);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "🔒 Parola:";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnGirisYap.Appearance.Options.UseForeColor = true;
            this.BtnGirisYap.Location = new System.Drawing.Point(247, 517);
            this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(325, 42);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "➡️ Giriş Yap";
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(220)))), ((int)(((byte)(151)))));
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(85, 570);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(442, 36);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "🌸 Doğanın Kucağında Huzurlu Konaklama!";
            // 
            // BtnKayit
            // 
            this.BtnKayit.Appearance.ForeColor = System.Drawing.Color.SpringGreen;
            this.BtnKayit.Appearance.Options.UseForeColor = true;
            this.BtnKayit.Location = new System.Drawing.Point(34, 517);
            this.BtnKayit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(200, 42);
            this.BtnKayit.TabIndex = 8;
            this.BtnKayit.Text = "📝 Kayıt Ol";
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 462);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(162, 36);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Şifremi Unuttum";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(247, 408);
            this.TxtParola.Margin = new System.Windows.Forms.Padding(6);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Properties.UseSystemPasswordChar = true;
            this.TxtParola.Size = new System.Drawing.Size(325, 42);
            this.TxtParola.TabIndex = 5;
            this.TxtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtParola_KeyDown);
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(247, 355);
            this.TxtKullaniciAdi.Margin = new System.Windows.Forms.Padding(5);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(325, 42);
            this.TxtKullaniciAdi.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::cicek_pansiyonu.Properties.Resources.admin_ana_logo;
            this.pictureEdit1.Location = new System.Drawing.Point(34, 1);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(540, 327);
            this.pictureEdit1.TabIndex = 1;
            // 
            // Form_admin_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 626);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.admin_logo_icon;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_admin_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.Form_admin_giris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_admin_giris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TxtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit TxtParola;
        private DevExpress.XtraEditors.SimpleButton BtnGirisYap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnKayit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

