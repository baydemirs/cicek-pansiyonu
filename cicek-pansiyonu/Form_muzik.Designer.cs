namespace cicek_pansiyonu
{
    partial class Form_muzik
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txteserurl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txteseradi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteserurl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteseradi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnbul);
            this.groupBox2.Controls.Add(this.btnekle);
            this.groupBox2.Controls.Add(this.txteserurl);
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.txteseradi);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 256);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "➕ Müzik Ekle";
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnguncelle.Location = new System.Drawing.Point(545, 152);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 75);
            this.btnguncelle.TabIndex = 31;
            this.btnguncelle.Text = "🔄 Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnsil.Location = new System.Drawing.Point(233, 152);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 75);
            this.btnsil.TabIndex = 32;
            this.btnsil.Text = "🗑️ Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnbul
            // 
            this.btnbul.BackColor = System.Drawing.Color.Transparent;
            this.btnbul.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnbul.Location = new System.Drawing.Point(389, 152);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(150, 75);
            this.btnbul.TabIndex = 33;
            this.btnbul.Text = "🔍 Bul";
            this.btnbul.UseVisualStyleBackColor = false;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Transparent;
            this.btnekle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnekle.Location = new System.Drawing.Point(77, 152);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(150, 75);
            this.btnekle.TabIndex = 27;
            this.btnekle.Text = "➕Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txteserurl
            // 
            this.txteserurl.Location = new System.Drawing.Point(190, 99);
            this.txteserurl.Margin = new System.Windows.Forms.Padding(8);
            this.txteserurl.Name = "txteserurl";
            this.txteserurl.Size = new System.Drawing.Size(505, 42);
            this.txteserurl.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(109, 102);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(24);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(73, 36);
            this.labelControl14.TabIndex = 23;
            this.labelControl14.Text = "🔗 URL:";
            // 
            // txteseradi
            // 
            this.txteseradi.Location = new System.Drawing.Point(190, 45);
            this.txteseradi.Margin = new System.Windows.Forms.Padding(4);
            this.txteseradi.Name = "txteseradi";
            this.txteseradi.Size = new System.Drawing.Size(505, 42);
            this.txteseradi.TabIndex = 15;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(73, 48);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(109, 36);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "🎶Eser Adı:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(601, 564);
            this.gridControl1.TabIndex = 35;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(724, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 606);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "🎶📋 Oynatma Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webView1);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 338);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "🎵 Oynatıcı";
            // 
            // webView1
            // 
            this.webView1.CreationProperties = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.Location = new System.Drawing.Point(21, 36);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(674, 296);
            this.webView1.TabIndex = 35;
            this.webView1.ZoomFactor = 1D;
            // 
            // Form_muzik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.muzikdinle_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_muzik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müzik Dinle";
            this.Load += new System.EventHandler(this.Form_muzik_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteserurl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteseradi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txteserurl;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txteseradi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Button btnekle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
    }
}