namespace KutuphaneOtomasyonu
{
    partial class YazarForm
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
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.lblYazarSoyadi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(557, 486);
            this.btnYazarEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(100, 28);
            this.btnYazarEkle.TabIndex = 16;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(524, 442);
            this.txtYazarSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(132, 22);
            this.txtYazarSoyadi.TabIndex = 15;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(524, 409);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(132, 22);
            this.txtYazarAdi.TabIndex = 14;
            // 
            // lblYazarSoyadi
            // 
            this.lblYazarSoyadi.AutoSize = true;
            this.lblYazarSoyadi.Location = new System.Drawing.Point(424, 446);
            this.lblYazarSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazarSoyadi.Name = "lblYazarSoyadi";
            this.lblYazarSoyadi.Size = new System.Drawing.Size(92, 17);
            this.lblYazarSoyadi.TabIndex = 13;
            this.lblYazarSoyadi.Text = "Yazar Soyadı";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(424, 409);
            this.lblYazarAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(69, 17);
            this.lblYazarAdi.TabIndex = 12;
            this.lblYazarAdi.Text = "Yazar Adı";
            // 
            // cmsSil
            // 
            this.cmsSil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(95, 28);
            this.cmsSil.Click += new System.EventHandler(this.cmsSil_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.ContextMenuStrip = this.cmsSil;
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.ItemHeight = 16;
            this.lstYazarlar.Location = new System.Drawing.Point(0, 0);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(1055, 292);
            this.lstYazarlar.TabIndex = 17;
            // 
            // YazarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.lblYazarSoyadi);
            this.Controls.Add(this.lblYazarAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YazarForm";
            this.Text = "YazarForm";
            this.Load += new System.EventHandler(this.YazarForm_Load);
            this.cmsSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label lblYazarSoyadi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ListBox lstYazarlar;
    }
}