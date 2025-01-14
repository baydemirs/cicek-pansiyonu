namespace cicek_pansiyonu
{
    partial class Form_AStarter
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
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.ProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelTelif = new DevExpress.XtraEditors.LabelControl();
            this.LblDurum = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::cicek_pansiyonu.Properties.Resources.admin_ana_logo;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 1);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(533, 262);
            this.pictureEdit1.TabIndex = 0;
            // 
            // peLogo
            // 
            this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peLogo.EditValue = global::cicek_pansiyonu.Properties.Resources.Fırat_üni__1_;
            this.peLogo.Location = new System.Drawing.Point(327, 326);
            this.peLogo.Margin = new System.Windows.Forms.Padding(4);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peLogo.Size = new System.Drawing.Size(198, 55);
            this.peLogo.TabIndex = 9;
            // 
            // ProgressBarControl1
            // 
            this.ProgressBarControl1.Location = new System.Drawing.Point(26, 297);
            this.ProgressBarControl1.Name = "ProgressBarControl1";
            this.ProgressBarControl1.Size = new System.Drawing.Size(499, 22);
            this.ProgressBarControl1.TabIndex = 10;
            // 
            // labelTelif
            // 
            this.labelTelif.Appearance.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelif.Appearance.Options.UseFont = true;
            this.labelTelif.Location = new System.Drawing.Point(26, 363);
            this.labelTelif.Name = "labelTelif";
            this.labelTelif.Size = new System.Drawing.Size(27, 31);
            this.labelTelif.TabIndex = 12;
            this.labelTelif.Text = "***";
            // 
            // LblDurum
            // 
            this.LblDurum.Location = new System.Drawing.Point(26, 255);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(120, 36);
            this.LblDurum.TabIndex = 11;
            this.LblDurum.Text = "Başlatılıyor...";
            // 
            // Form_AStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 406);
            this.Controls.Add(this.labelTelif);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.ProgressBarControl1);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.pictureEdit1);
            this.IconOptions.Image = global::cicek_pansiyonu.Properties.Resources.admin_logo_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AStarter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiçek Pansiyonu";
            this.Load += new System.EventHandler(this.Form_AStarter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelTelif;
        private DevExpress.XtraEditors.LabelControl LblDurum;
    }
}