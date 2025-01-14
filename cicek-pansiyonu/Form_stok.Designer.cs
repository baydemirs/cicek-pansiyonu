namespace cicek_pansiyonu
{
    partial class Form_stok
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpStokTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnStokEkle = new System.Windows.Forms.Button();
            this.TxtStokFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtStokTürü = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.TxtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtpFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnFaturaEkle = new System.Windows.Forms.Button();
            this.TxtFaturaFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaTürü = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Usil = new System.Windows.Forms.Button();
            this.UDtp = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Uguncelle = new System.Windows.Forms.Button();
            this.UTxtFaturaFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.UFaturaTürü = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.UFaturaAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokTürü.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdi.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTürü.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UTxtFaturaFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFaturaTürü.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFaturaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpStokTarihi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.BtnStokEkle);
            this.groupBox1.Controls.Add(this.TxtStokFiyat);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.TxtStokTürü);
            this.groupBox1.Controls.Add(this.labelControl14);
            this.groupBox1.Controls.Add(this.TxtStokAdi);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 320);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "📦 Stok Ekle";
            // 
            // DtpStokTarihi
            // 
            this.DtpStokTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpStokTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpStokTarihi.Location = new System.Drawing.Point(173, 200);
            this.DtpStokTarihi.Name = "DtpStokTarihi";
            this.DtpStokTarihi.Size = new System.Drawing.Size(370, 37);
            this.DtpStokTarihi.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 198);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 36);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "📅 Stok Tarihi:\n";
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.BackColor = System.Drawing.Color.Transparent;
            this.BtnStokEkle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnStokEkle.Location = new System.Drawing.Point(173, 260);
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.Size = new System.Drawing.Size(370, 48);
            this.BtnStokEkle.TabIndex = 26;
            this.BtnStokEkle.Text = "📦➕ Stok Ekle";
            this.BtnStokEkle.UseVisualStyleBackColor = false;
            this.BtnStokEkle.Click += new System.EventHandler(this.BtnStokEkle_Click);
            // 
            // TxtStokFiyat
            // 
            this.TxtStokFiyat.Location = new System.Drawing.Point(173, 147);
            this.TxtStokFiyat.Margin = new System.Windows.Forms.Padding(8);
            this.TxtStokFiyat.Name = "TxtStokFiyat";
            this.TxtStokFiyat.Size = new System.Drawing.Size(370, 42);
            this.TxtStokFiyat.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 148);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 36);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "💰 Fiyat:";
            // 
            // TxtStokTürü
            // 
            this.TxtStokTürü.Location = new System.Drawing.Point(173, 99);
            this.TxtStokTürü.Margin = new System.Windows.Forms.Padding(8);
            this.TxtStokTürü.Name = "TxtStokTürü";
            this.TxtStokTürü.Size = new System.Drawing.Size(370, 42);
            this.TxtStokTürü.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(32, 98);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(129, 36);
            this.labelControl14.TabIndex = 23;
            this.labelControl14.Text = "📂 Stok Türü:";
            // 
            // TxtStokAdi
            // 
            this.TxtStokAdi.Location = new System.Drawing.Point(173, 45);
            this.TxtStokAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStokAdi.Name = "TxtStokAdi";
            this.TxtStokAdi.Size = new System.Drawing.Size(370, 42);
            this.TxtStokAdi.TabIndex = 15;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(44, 48);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(117, 36);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "🏷️ Stok Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtpFaturaTarihi);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.BtnFaturaEkle);
            this.groupBox2.Controls.Add(this.TxtFaturaFiyat);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.TxtFaturaTürü);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.TxtFaturaAdı);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(591, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 320);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🧾 Fatura Ekle";
            // 
            // DtpFaturaTarihi
            // 
            this.DtpFaturaTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpFaturaTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpFaturaTarihi.Location = new System.Drawing.Point(178, 200);
            this.DtpFaturaTarihi.Name = "DtpFaturaTarihi";
            this.DtpFaturaTarihi.Size = new System.Drawing.Size(370, 37);
            this.DtpFaturaTarihi.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 198);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 36);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "📅 Fatura Tarihi:\n";
            // 
            // BtnFaturaEkle
            // 
            this.BtnFaturaEkle.BackColor = System.Drawing.Color.Transparent;
            this.BtnFaturaEkle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnFaturaEkle.Location = new System.Drawing.Point(178, 260);
            this.BtnFaturaEkle.Name = "BtnFaturaEkle";
            this.BtnFaturaEkle.Size = new System.Drawing.Size(370, 48);
            this.BtnFaturaEkle.TabIndex = 26;
            this.BtnFaturaEkle.Text = "📄➕ Fatura Ekle";
            this.BtnFaturaEkle.UseVisualStyleBackColor = false;
            this.BtnFaturaEkle.Click += new System.EventHandler(this.BtnFaturaEkle_Click);
            // 
            // TxtFaturaFiyat
            // 
            this.TxtFaturaFiyat.Location = new System.Drawing.Point(178, 147);
            this.TxtFaturaFiyat.Margin = new System.Windows.Forms.Padding(8);
            this.TxtFaturaFiyat.Name = "TxtFaturaFiyat";
            this.TxtFaturaFiyat.Size = new System.Drawing.Size(370, 42);
            this.TxtFaturaFiyat.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(86, 150);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 36);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "💰 Fiyat:";
            // 
            // TxtFaturaTürü
            // 
            this.TxtFaturaTürü.Location = new System.Drawing.Point(178, 99);
            this.TxtFaturaTürü.Margin = new System.Windows.Forms.Padding(8);
            this.TxtFaturaTürü.Name = "TxtFaturaTürü";
            this.TxtFaturaTürü.Size = new System.Drawing.Size(370, 42);
            this.TxtFaturaTürü.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 100);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(152, 36);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "📂 Fatura Türü:";
            // 
            // TxtFaturaAdı
            // 
            this.TxtFaturaAdı.Location = new System.Drawing.Point(178, 45);
            this.TxtFaturaAdı.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaturaAdı.Name = "TxtFaturaAdı";
            this.TxtFaturaAdı.Size = new System.Drawing.Size(370, 42);
            this.TxtFaturaAdı.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 50);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(140, 36);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "✏️ Fatura Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 356);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(853, 414);
            this.gridControl1.TabIndex = 31;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Usil);
            this.groupBox3.Controls.Add(this.UDtp);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.Uguncelle);
            this.groupBox3.Controls.Add(this.UTxtFaturaFiyat);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.UFaturaTürü);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.UFaturaAdı);
            this.groupBox3.Controls.Add(this.labelControl10);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(1175, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 320);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "⚙️ Stok İşlemleri";
            // 
            // Usil
            // 
            this.Usil.AutoSize = true;
            this.Usil.BackColor = System.Drawing.Color.Transparent;
            this.Usil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Usil.Location = new System.Drawing.Point(172, 260);
            this.Usil.Name = "Usil";
            this.Usil.Size = new System.Drawing.Size(180, 48);
            this.Usil.TabIndex = 30;
            this.Usil.Text = "🗑️ Sil";
            this.Usil.UseVisualStyleBackColor = false;
            this.Usil.Click += new System.EventHandler(this.Usil_Click);
            // 
            // UDtp
            // 
            this.UDtp.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.UDtp.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.UDtp.Location = new System.Drawing.Point(172, 200);
            this.UDtp.Name = "UDtp";
            this.UDtp.Size = new System.Drawing.Size(370, 37);
            this.UDtp.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(76, 198);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 36);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "📅 Tarih:\n";
            // 
            // Uguncelle
            // 
            this.Uguncelle.BackColor = System.Drawing.Color.Transparent;
            this.Uguncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Uguncelle.Location = new System.Drawing.Point(362, 260);
            this.Uguncelle.Name = "Uguncelle";
            this.Uguncelle.Size = new System.Drawing.Size(180, 48);
            this.Uguncelle.TabIndex = 26;
            this.Uguncelle.Text = "🔄 Güncelle";
            this.Uguncelle.UseVisualStyleBackColor = false;
            this.Uguncelle.Click += new System.EventHandler(this.Uguncelle_Click);
            // 
            // UTxtFaturaFiyat
            // 
            this.UTxtFaturaFiyat.Location = new System.Drawing.Point(172, 147);
            this.UTxtFaturaFiyat.Margin = new System.Windows.Forms.Padding(8);
            this.UTxtFaturaFiyat.Name = "UTxtFaturaFiyat";
            this.UTxtFaturaFiyat.Size = new System.Drawing.Size(370, 42);
            this.UTxtFaturaFiyat.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(79, 148);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 36);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "💰 Fiyat:";
            // 
            // UFaturaTürü
            // 
            this.UFaturaTürü.Location = new System.Drawing.Point(172, 99);
            this.UFaturaTürü.Margin = new System.Windows.Forms.Padding(8);
            this.UFaturaTürü.Name = "UFaturaTürü";
            this.UFaturaTürü.Size = new System.Drawing.Size(370, 42);
            this.UFaturaTürü.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 98);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(152, 36);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "📂 Fatura Türü:";
            // 
            // UFaturaAdı
            // 
            this.UFaturaAdı.Location = new System.Drawing.Point(172, 45);
            this.UFaturaAdı.Margin = new System.Windows.Forms.Padding(4);
            this.UFaturaAdı.Name = "UFaturaAdı";
            this.UFaturaAdı.Size = new System.Drawing.Size(370, 42);
            this.UFaturaAdı.TabIndex = 15;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(24, 48);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(140, 36);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "✏️ Fatura Adı:";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(883, 356);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(847, 414);
            this.gridControl2.TabIndex = 32;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Form_stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 790);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.stoklar_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok ve Fatura işlemleri";
            this.Load += new System.EventHandler(this.Form_stok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokTürü.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStokAdi.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaTürü.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UTxtFaturaFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFaturaTürü.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFaturaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit TxtStokTürü;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit TxtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtStokFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button BtnStokEkle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker DtpStokTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtpFaturaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button BtnFaturaEkle;
        private DevExpress.XtraEditors.TextEdit TxtFaturaFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtFaturaTürü;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtFaturaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker UDtp;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Button Uguncelle;
        private DevExpress.XtraEditors.TextEdit UTxtFaturaFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit UFaturaTürü;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit UFaturaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.Button Usil;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}