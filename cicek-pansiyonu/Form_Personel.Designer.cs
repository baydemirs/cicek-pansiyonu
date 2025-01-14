namespace cicek_pansiyonu
{
    partial class Form_Personel
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnPersonelSil = new System.Windows.Forms.Button();
            this.BtnPersonelEkle = new System.Windows.Forms.Button();
            this.BtnPersonelBul = new System.Windows.Forms.Button();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.BtnPersonelGuncelle = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSaatFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCalismaSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonelAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaatFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCalismaSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.BtnPersonelSil);
            this.groupBox1.Controls.Add(this.BtnPersonelEkle);
            this.groupBox1.Controls.Add(this.BtnPersonelBul);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.BtnPersonelGuncelle);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.TxtSaatFiyat);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.TxtCalismaSaat);
            this.groupBox1.Controls.Add(this.labelControl14);
            this.groupBox1.Controls.Add(this.TxtPersonelAdi);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 293);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "👔 Personel İşlemleri";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpCikisTarihi.Location = new System.Drawing.Point(279, 234);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(370, 37);
            this.DtpCikisTarihi.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 236);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(232, 36);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "📅 Personel Çıkış Tarihi:\n";
            // 
            // BtnPersonelSil
            // 
            this.BtnPersonelSil.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonelSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnPersonelSil.Location = new System.Drawing.Point(958, 48);
            this.BtnPersonelSil.Name = "BtnPersonelSil";
            this.BtnPersonelSil.Size = new System.Drawing.Size(268, 55);
            this.BtnPersonelSil.TabIndex = 30;
            this.BtnPersonelSil.Text = "👔🗑️ Personeli Sil";
            this.BtnPersonelSil.UseVisualStyleBackColor = false;
            this.BtnPersonelSil.Click += new System.EventHandler(this.BtnPersonelSil_Click);
            // 
            // BtnPersonelEkle
            // 
            this.BtnPersonelEkle.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonelEkle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnPersonelEkle.Location = new System.Drawing.Point(660, 48);
            this.BtnPersonelEkle.Name = "BtnPersonelEkle";
            this.BtnPersonelEkle.Size = new System.Drawing.Size(268, 55);
            this.BtnPersonelEkle.TabIndex = 26;
            this.BtnPersonelEkle.Text = "👔➕ Personeli Ekle";
            this.BtnPersonelEkle.UseVisualStyleBackColor = false;
            this.BtnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click);
            // 
            // BtnPersonelBul
            // 
            this.BtnPersonelBul.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonelBul.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnPersonelBul.Location = new System.Drawing.Point(958, 148);
            this.BtnPersonelBul.Name = "BtnPersonelBul";
            this.BtnPersonelBul.Size = new System.Drawing.Size(268, 55);
            this.BtnPersonelBul.TabIndex = 32;
            this.BtnPersonelBul.Text = "👔🔍 Personeli Bul";
            this.BtnPersonelBul.UseVisualStyleBackColor = false;
            this.BtnPersonelBul.Click += new System.EventHandler(this.BtnPersonelBul_Click);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpGirisTarihi.Location = new System.Drawing.Point(279, 195);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(370, 37);
            this.DtpGirisTarihi.TabIndex = 29;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // BtnPersonelGuncelle
            // 
            this.BtnPersonelGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonelGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnPersonelGuncelle.Location = new System.Drawing.Point(660, 148);
            this.BtnPersonelGuncelle.Name = "BtnPersonelGuncelle";
            this.BtnPersonelGuncelle.Size = new System.Drawing.Size(268, 55);
            this.BtnPersonelGuncelle.TabIndex = 31;
            this.BtnPersonelGuncelle.Text = "👔🔄 Personeli Güncelle";
            this.BtnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.BtnPersonelGuncelle.Click += new System.EventHandler(this.BtnPersonelGuncelle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 197);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(230, 36);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "📅 Personel Giriş Tarihi:\n";
            // 
            // TxtSaatFiyat
            // 
            this.TxtSaatFiyat.Location = new System.Drawing.Point(279, 142);
            this.TxtSaatFiyat.Margin = new System.Windows.Forms.Padding(8);
            this.TxtSaatFiyat.Name = "TxtSaatFiyat";
            this.TxtSaatFiyat.Size = new System.Drawing.Size(370, 42);
            this.TxtSaatFiyat.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(93, 148);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(178, 36);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "💲Saat Başı Fiyat:";
            // 
            // TxtCalismaSaat
            // 
            this.TxtCalismaSaat.Location = new System.Drawing.Point(279, 92);
            this.TxtCalismaSaat.Margin = new System.Windows.Forms.Padding(8);
            this.TxtCalismaSaat.Name = "TxtCalismaSaat";
            this.TxtCalismaSaat.Size = new System.Drawing.Size(370, 42);
            this.TxtCalismaSaat.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(16, 98);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(255, 36);
            this.labelControl14.TabIndex = 23;
            this.labelControl14.Text = "⏰     Günlük Çalışma Saati:";
            // 
            // TxtPersonelAdi
            // 
            this.TxtPersonelAdi.Location = new System.Drawing.Point(279, 45);
            this.TxtPersonelAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPersonelAdi.Name = "TxtPersonelAdi";
            this.TxtPersonelAdi.Size = new System.Drawing.Size(370, 42);
            this.TxtPersonelAdi.TabIndex = 15;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(112, 48);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(159, 36);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "👤 Personel Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 311);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1234, 352);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // Form_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 677);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.personel_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.Form_Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaatFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCalismaSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button BtnPersonelEkle;
        private DevExpress.XtraEditors.TextEdit TxtSaatFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtCalismaSaat;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit TxtPersonelAdi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Button BtnPersonelBul;
        private System.Windows.Forms.Button BtnPersonelGuncelle;
        private System.Windows.Forms.Button BtnPersonelSil;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}