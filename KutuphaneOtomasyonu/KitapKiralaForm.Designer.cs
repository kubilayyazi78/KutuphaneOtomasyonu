namespace KutuphaneOtomasyonu
{
    partial class KitapKiralaForm
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
            this.btnKirala = new System.Windows.Forms.Button();
            this.cmbUyeAdi = new System.Windows.Forms.ComboBox();
            this.cmbKitapAdi = new System.Windows.Forms.ComboBox();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblUyeAd = new System.Windows.Forms.Label();
            this.lstKitapKirala = new System.Windows.Forms.ListView();
            this.UyeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimAlinanTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(412, 360);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 30;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(366, 273);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbUyeAdi.TabIndex = 29;
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Location = new System.Drawing.Point(366, 318);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbKitapAdi.TabIndex = 28;
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(309, 326);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(49, 13);
            this.lblKitapAd.TabIndex = 27;
            this.lblKitapAd.Text = "Kitap Adı";
            // 
            // lblUyeAd
            // 
            this.lblUyeAd.AutoSize = true;
            this.lblUyeAd.Location = new System.Drawing.Point(309, 281);
            this.lblUyeAd.Name = "lblUyeAd";
            this.lblUyeAd.Size = new System.Drawing.Size(44, 13);
            this.lblUyeAd.TabIndex = 26;
            this.lblUyeAd.Text = "Uye Adı";
            // 
            // lstKitapKirala
            // 
            this.lstKitapKirala.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UyeAdi,
            this.KitapAdi,
            this.TeslimAlinanTarih});
            this.lstKitapKirala.Location = new System.Drawing.Point(0, 12);
            this.lstKitapKirala.Name = "lstKitapKirala";
            this.lstKitapKirala.Size = new System.Drawing.Size(788, 236);
            this.lstKitapKirala.TabIndex = 32;
            this.lstKitapKirala.UseCompatibleStateImageBehavior = false;
            this.lstKitapKirala.View = System.Windows.Forms.View.Details;
            // 
            // UyeAdi
            // 
            this.UyeAdi.Text = "Uye Adi";
            this.UyeAdi.Width = 120;
            // 
            // KitapAdi
            // 
            this.KitapAdi.Text = "Kitap Adı";
            this.KitapAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapAdi.Width = 120;
            // 
            // TeslimAlinanTarih
            // 
            this.TeslimAlinanTarih.Text = "Teslim Alınan Tarih";
            this.TeslimAlinanTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeslimAlinanTarih.Width = 150;
            // 
            // KitapKiralaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKitapKirala);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.cmbKitapAdi);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblUyeAd);
            this.Name = "KitapKiralaForm";
            this.Text = "KitapKiralaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox cmbUyeAdi;
        private System.Windows.Forms.ComboBox cmbKitapAdi;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblUyeAd;
        private System.Windows.Forms.ListView lstKitapKirala;
        private System.Windows.Forms.ColumnHeader UyeAdi;
        private System.Windows.Forms.ColumnHeader KitapAdi;
        private System.Windows.Forms.ColumnHeader TeslimAlinanTarih;
    }
}