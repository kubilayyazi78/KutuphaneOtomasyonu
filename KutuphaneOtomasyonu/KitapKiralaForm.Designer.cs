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
            this.dgvKirala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKirala)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(549, 443);
            this.btnKirala.Margin = new System.Windows.Forms.Padding(4);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(100, 28);
            this.btnKirala.TabIndex = 30;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(488, 336);
            this.cmbUyeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(160, 24);
            this.cmbUyeAdi.TabIndex = 29;
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Location = new System.Drawing.Point(488, 391);
            this.cmbKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(160, 24);
            this.cmbKitapAdi.TabIndex = 28;
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(412, 401);
            this.lblKitapAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(64, 17);
            this.lblKitapAd.TabIndex = 27;
            this.lblKitapAd.Text = "Kitap Adı";
            // 
            // lblUyeAd
            // 
            this.lblUyeAd.AutoSize = true;
            this.lblUyeAd.Location = new System.Drawing.Point(412, 346);
            this.lblUyeAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeAd.Name = "lblUyeAd";
            this.lblUyeAd.Size = new System.Drawing.Size(57, 17);
            this.lblUyeAd.TabIndex = 26;
            this.lblUyeAd.Text = "Uye Adı";
            // 
            // dgvKirala
            // 
            this.dgvKirala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKirala.Location = new System.Drawing.Point(0, 0);
            this.dgvKirala.Name = "dgvKirala";
            this.dgvKirala.RowTemplate.Height = 24;
            this.dgvKirala.Size = new System.Drawing.Size(1068, 311);
            this.dgvKirala.TabIndex = 31;
            // 
            // KitapKiralaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvKirala);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.cmbKitapAdi);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblUyeAd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KitapKiralaForm";
            this.Text = "KitapKiralaForm";
            this.Load += new System.EventHandler(this.KitapKiralaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKirala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox cmbUyeAdi;
        private System.Windows.Forms.ComboBox cmbKitapAdi;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblUyeAd;
        private System.Windows.Forms.DataGridView dgvKirala;
    }
}