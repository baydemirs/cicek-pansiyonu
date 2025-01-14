namespace cicek_pansiyonu
{
    partial class Form_musteriler
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
            this.musteriEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cicekPansiyonDataSet = new cicek_pansiyonu.CicekPansiyonDataSet();
            this.musteriEkleTableAdapter = new cicek_pansiyonu.CicekPansiyonDataSetTableAdapters.MusteriEkleTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MstGoster = new DevExpress.XtraEditors.SimpleButton();
            this.MstGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.MstSil = new DevExpress.XtraEditors.SimpleButton();
            this.MüsteriyiBul = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new DevExpress.XtraEditors.TextEdit();
            this.TxtOdaNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtKimlikNo = new DevExpress.XtraEditors.TextEdit();
            this.MskTxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.Txtadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBulTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBulTC = new DevExpress.XtraEditors.TextEdit();
            this.TxtBulAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekPansiyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOdaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKimlikNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MskTxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadi.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulAdi.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriEkleBindingSource
            // 
            this.musteriEkleBindingSource.DataMember = "MusteriEkle";
            this.musteriEkleBindingSource.DataSource = this.cicekPansiyonDataSet;
            // 
            // cicekPansiyonDataSet
            // 
            this.cicekPansiyonDataSet.DataSetName = "CicekPansiyonDataSet";
            this.cicekPansiyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriEkleTableAdapter
            // 
            this.musteriEkleTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 619);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1338, 352);
            this.gridControl1.TabIndex = 0;
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
            // MstGoster
            // 
            this.MstGoster.ImageOptions.Image = global::cicek_pansiyonu.Properties.Resources.müsteri_ekle_göster;
            this.MstGoster.Location = new System.Drawing.Point(9, 36);
            this.MstGoster.Name = "MstGoster";
            this.MstGoster.Size = new System.Drawing.Size(300, 140);
            this.MstGoster.TabIndex = 11;
            this.MstGoster.Text = "Müşteriyi Göster";
            this.MstGoster.Click += new System.EventHandler(this.MstGoster_Click);
            // 
            // MstGuncelle
            // 
            this.MstGuncelle.ImageOptions.Image = global::cicek_pansiyonu.Properties.Resources.müsteri_ekle_güncelle;
            this.MstGuncelle.Location = new System.Drawing.Point(331, 35);
            this.MstGuncelle.Name = "MstGuncelle";
            this.MstGuncelle.Size = new System.Drawing.Size(300, 140);
            this.MstGuncelle.TabIndex = 12;
            this.MstGuncelle.Text = "Müşteriyi Güncelle";
            this.MstGuncelle.Click += new System.EventHandler(this.MstGuncelle_Click);
            // 
            // MstSil
            // 
            this.MstSil.ImageOptions.Image = global::cicek_pansiyonu.Properties.Resources.müsteri_ekle_sil;
            this.MstSil.Location = new System.Drawing.Point(331, 192);
            this.MstSil.Name = "MstSil";
            this.MstSil.Size = new System.Drawing.Size(300, 140);
            this.MstSil.TabIndex = 14;
            this.MstSil.Text = "Müşteriyi Sil";
            this.MstSil.Click += new System.EventHandler(this.MstSil_Click);
            // 
            // MüsteriyiBul
            // 
            this.MüsteriyiBul.ImageOptions.Image = global::cicek_pansiyonu.Properties.Resources.müsteri_ekle_ara;
            this.MüsteriyiBul.Location = new System.Drawing.Point(9, 192);
            this.MüsteriyiBul.Name = "MüsteriyiBul";
            this.MüsteriyiBul.Size = new System.Drawing.Size(300, 140);
            this.MüsteriyiBul.TabIndex = 13;
            this.MüsteriyiBul.Text = "Müşteriyi Bul";
            this.MüsteriyiBul.Click += new System.EventHandler(this.MüsteriyiBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBoxEdit1);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.TxtKimlikNo);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.Txtadi);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 602);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "⚙️ Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "0";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Cinsiyet seçiniz...";
            this.comboBoxEdit1.Location = new System.Drawing.Point(224, 135);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(446, 42);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(101, 136);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(19);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(112, 36);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "⚧    Cinsiyet:";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpCikisTarihi.Location = new System.Drawing.Point(224, 544);
            this.DtpCikisTarihi.Margin = new System.Windows.Forms.Padding(100);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpCikisTarihi.Size = new System.Drawing.Size(446, 37);
            this.DtpCikisTarihi.TabIndex = 10;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.CalendarFont = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.DtpGirisTarihi.Location = new System.Drawing.Point(224, 491);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(446, 37);
            this.DtpGirisTarihi.TabIndex = 9;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(224, 424);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(15);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtUcret.Properties.MaskSettings.Set("mask", "f");
            this.TxtUcret.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtUcret.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.TxtUcret.Size = new System.Drawing.Size(446, 46);
            this.TxtUcret.TabIndex = 8;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Location = new System.Drawing.Point(224, 366);
            this.TxtOdaNo.Margin = new System.Windows.Forms.Padding(12);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.TxtOdaNo.Size = new System.Drawing.Size(446, 46);
            this.TxtOdaNo.TabIndex = 7;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Location = new System.Drawing.Point(224, 302);
            this.TxtKimlikNo.Margin = new System.Windows.Forms.Padding(10);
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Properties.MaxLength = 11;
            this.TxtKimlikNo.Size = new System.Drawing.Size(446, 42);
            this.TxtKimlikNo.TabIndex = 6;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Location = new System.Drawing.Point(224, 242);
            this.MskTxtTelefon.Margin = new System.Windows.Forms.Padding(8);
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.MskTxtTelefon.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.MskTxtTelefon.Size = new System.Drawing.Size(446, 42);
            this.MskTxtTelefon.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(102, 246);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(111, 36);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "📞 Telefon:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(224, 186);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(6);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(446, 42);
            this.TxtMail.TabIndex = 4;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(224, 89);
            this.TxtSoyadi.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(446, 42);
            this.TxtSoyadi.TabIndex = 2;
            // 
            // Txtadi
            // 
            this.Txtadi.Location = new System.Drawing.Point(224, 37);
            this.Txtadi.Margin = new System.Windows.Forms.Padding(4);
            this.Txtadi.Name = "Txtadi";
            this.Txtadi.Size = new System.Drawing.Size(446, 42);
            this.Txtadi.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(71, 544);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(19);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(143, 36);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "📆 Çıkış Tarihi:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(73, 491);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(141, 36);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "📅 Giriş Tarihi:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(124, 428);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 36);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "💰 Ücret:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 370);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(185, 36);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "🔢 Oda Numarası:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 306);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 36);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "🆔 T.C. Kimlik No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(134, 190);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 36);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "📧 Mail:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(106, 93);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 36);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "📝 Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(143, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "👤 Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBulTel);
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.TxtBulTC);
            this.groupBox2.Controls.Add(this.TxtBulAdi);
            this.groupBox2.Controls.Add(this.labelControl13);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(713, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 234);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🔍 Müşteriyi Bul";
            // 
            // TxtBulTel
            // 
            this.TxtBulTel.Location = new System.Drawing.Point(194, 109);
            this.TxtBulTel.Margin = new System.Windows.Forms.Padding(8);
            this.TxtBulTel.Name = "TxtBulTel";
            this.TxtBulTel.Size = new System.Drawing.Size(421, 42);
            this.TxtBulTel.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(75, 112);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(111, 36);
            this.labelControl14.TabIndex = 23;
            this.labelControl14.Text = "📞 Telefon:";
            // 
            // TxtBulTC
            // 
            this.TxtBulTC.Location = new System.Drawing.Point(194, 174);
            this.TxtBulTC.Margin = new System.Windows.Forms.Padding(10);
            this.TxtBulTC.Name = "TxtBulTC";
            this.TxtBulTC.Properties.MaxLength = 11;
            this.TxtBulTC.Size = new System.Drawing.Size(421, 42);
            this.TxtBulTC.TabIndex = 16;
            // 
            // TxtBulAdi
            // 
            this.TxtBulAdi.Location = new System.Drawing.Point(194, 55);
            this.TxtBulAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBulAdi.Name = "TxtBulAdi";
            this.TxtBulAdi.Size = new System.Drawing.Size(421, 42);
            this.TxtBulAdi.TabIndex = 15;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(19, 180);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(167, 36);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "🆔 T.C. Kimlik No:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(116, 58);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(70, 36);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "👤 Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MstSil);
            this.groupBox3.Controls.Add(this.MüsteriyiBul);
            this.groupBox3.Controls.Add(this.MstGoster);
            this.groupBox3.Controls.Add(this.MstGuncelle);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(713, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 362);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "⚙️İşlemler";
            // 
            // Form_musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 977);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.anasayfa_musteriler;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Form_musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicekPansiyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOdaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKimlikNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MskTxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadi.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBulAdi.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CicekPansiyonDataSet cicekPansiyonDataSet;
        private System.Windows.Forms.BindingSource musteriEkleBindingSource;
        private CicekPansiyonDataSetTableAdapters.MusteriEkleTableAdapter musteriEkleTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton MstGoster;
        private DevExpress.XtraEditors.SimpleButton MstGuncelle;
        private DevExpress.XtraEditors.SimpleButton MstSil;
        private DevExpress.XtraEditors.SimpleButton MüsteriyiBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private DevExpress.XtraEditors.TextEdit TxtUcret;
        private DevExpress.XtraEditors.TextEdit TxtOdaNo;
        private DevExpress.XtraEditors.TextEdit TxtKimlikNo;
        private DevExpress.XtraEditors.TextEdit MskTxtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtSoyadi;
        private DevExpress.XtraEditors.TextEdit Txtadi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit TxtBulTel;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit TxtBulTC;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtBulAdi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}