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
            this.lstKira = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnKirala
            // 
            this.btnKirala.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.Location = new System.Drawing.Point(785, 257);
            this.btnKirala.Margin = new System.Windows.Forms.Padding(4);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(160, 44);
            this.btnKirala.TabIndex = 30;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(785, 147);
            this.cmbUyeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(160, 37);
            this.cmbUyeAdi.TabIndex = 29;
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Location = new System.Drawing.Point(785, 202);
            this.cmbKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(160, 37);
            this.cmbKitapAdi.TabIndex = 28;
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAd.Location = new System.Drawing.Point(674, 210);
            this.lblKitapAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(104, 29);
            this.lblKitapAd.TabIndex = 27;
            this.lblKitapAd.Text = "Kitap Adı";
            // 
            // lblUyeAd
            // 
            this.lblUyeAd.AutoSize = true;
            this.lblUyeAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeAd.Location = new System.Drawing.Point(674, 155);
            this.lblUyeAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyeAd.Name = "lblUyeAd";
            this.lblUyeAd.Size = new System.Drawing.Size(92, 29);
            this.lblUyeAd.TabIndex = 26;
            this.lblUyeAd.Text = "Uye Adı";
            // 
            // lstKira
            // 
            this.lstKira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKira.FormattingEnabled = true;
            this.lstKira.ItemHeight = 20;
            this.lstKira.Location = new System.Drawing.Point(25, 100);
            this.lstKira.Name = "lstKira";
            this.lstKira.Size = new System.Drawing.Size(617, 244);
            this.lstKira.TabIndex = 31;
            // 
            // KitapKiralaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kira;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.lstKira);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.cmbKitapAdi);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblUyeAd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KitapKiralaForm";
            this.Text = "KitapKiralaForm";
            this.Load += new System.EventHandler(this.KitapKiralaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox cmbUyeAdi;
        private System.Windows.Forms.ComboBox cmbKitapAdi;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblUyeAd;
        private System.Windows.Forms.ListBox lstKira;
    }
}